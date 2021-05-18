open Fake.Core
open Fake.Core.TargetOperators 
open Fake.IO    
open Fable.FakeHelpers
open Fake.IO.FileSystemOperators   
open Fake.IO.Globbing.Operators
open Helpers
open Fake.Api
let execContext = Context.FakeExecutionContext.Create false "build.fsx" [ ]
Context.setExecutionContext (Context.RuntimeContext.Fake execContext)

let buildDir  = "./build/"

let project = "fable-react-native"     
let gitOwner = "fable-compiler"

let CWD = __SOURCE_DIRECTORY__

let mutable dotnetExePath = Environment.environVarOrDefault "DOTNET" "dotnet"

// Clean and install dotnet SDK
Target.create "Clean" (fun _ ->
    !!"src/**/bin"
    |> Shell.cleanDirs
    !! "src/**/obj/*.nuspec"
    |> Shell.cleanDirs

    Shell.cleanDirs [buildDir; "temp"; "docs/output"]
)

Target.create "PublishPackages" (fun _ ->
    [ "src/Fable.React.Native.fsproj"]
    |> publishPackages CWD dotnetExePath
)

Target.create "GitHubRelease" (fun _ ->
    let releasePath = CWD </> "RELEASE_NOTES.md"
    githubRelease releasePath gitOwner project (fun user pw release ->
        GitHub.createClient user pw
        |> GitHub.draftNewRelease gitOwner project release.NugetVersion
            (release.SemVer.PreRelease <> None) release.Notes
        |> GitHub.publishDraft
        |> Async.RunSynchronously
    )
    )

let docsSrcPath = Path.getFullName "./src/Docs"
let docsDeployPath = "docs"

Target.create "InstallDocs" (fun _ ->

    run npm "install --frozen-lockfile" docsSrcPath
    run dotnet "restore" docsSrcPath )

Target.create "PublishDocs" (fun _ ->
    [ docsDeployPath] |> Shell.cleanDirs
    run dotnet "fable --run webpack-cli -p" docsSrcPath
)


Target.create "RunDocs" (fun _ ->
    run dotnet "fable watch --run webpack-dev-server --outDir src/Docs/output" docsSrcPath)

let dependencies = [

    "Clean"  
    ==> "PublishPackages"
    ==> "GitHubRelease"

    "InstallDocs"
        ==> "RunDocs"

    "InstallDocs"
        ==> "PublishDocs"
]

[<EntryPoint>]
let main args =
    try
        match args with
        | [| target |] -> Target.runOrDefault target
        | _ -> Target.runOrDefault "Run"
        0
    with e ->
        printfn "%A" e
        1
