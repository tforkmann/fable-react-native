module Views.Fable.React.Native

open Feliz
open Feliz.Bulma


let overview =
    Html.div [
        Bulma.title.h1 [
            Html.text "Fable.React.Native - Documentation"
            Html.a [
                prop.href "https://www.nuget.org/packages/Fable.React.Native /"
                prop.children [
                    Html.img [
                        prop.src "https://img.shields.io/nuget/v/Fable.React.Native.svg?style=flat"
                    ]
                ]
            ]
        ]
        Bulma.subtitle.h2 [
            Html.text "Fable bindings and helpers for React Native projects."
        ]
        Html.hr [
          ]
        // Bulma.content [
        //     Bulma.title.h4 "Features"
        //     Html.ul [
        //         Html.li "column interactions (resize, reorder and pin columns="
        //         Html.li "Pagination"
        //         Html.li "Sorting"
        //         Html.li "Row selection"
        //         Html.li "Data export"
        //     ]
        // ]
        Shared.fixDocsView "Fable.React.Native" false
    ]
let installation = Shared.installationView "Fable.React.Native"
