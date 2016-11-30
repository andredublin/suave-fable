module Server.Views

#r "../../packages/Suave/lib/net40/Suave.dll"
#r "../../packages/Suave.Experimental/lib/net40/Suave.Experimental.dll"

open Suave
open Suave.Html

let divId id = divAttr ["id", id]

let index =
    html [
        head [
            title "Foobar"
        ]
        body [
            divId "main" []
            scriptAttr [ "type", "text/javascript"; " src", "/bundle.js" ] [ text "" ]
        ]
    ]
    |> xmlToString