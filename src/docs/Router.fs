module Router

open Feliz.Router

type Page =
    | FableReactNative
    | FableReactNativeInstallation
    | FableReactNativeProps

let defaultPage = FableReactNative

let parseUrl = function
    | [ "" ] -> FableReactNative
    | [ "installation" ] -> FableReactNativeInstallation
    | [ "props" ] -> FableReactNativeProps
    | _ -> defaultPage

let getHref = function
    | FableReactNative -> Router.format("")
    | FableReactNativeInstallation -> Router.format("installation")
    | FableReactNativeProps -> Router.format("props")
  