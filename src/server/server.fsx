// --------------------------------------------------------------------------------------
// Start up Suave.io
// --------------------------------------------------------------------------------------

#r "../../packages/Suave/lib/net40/Suave.dll"

#load "routes.fsx"
#load "views.fsx"

open Suave
open Suave.Successful
open Suave.Files
open Suave.Operators
open Suave.Filters
open System.IO

open Server

let index =
    choose [
        GET >=> OK Views.index
    ]

let app = 
    choose [
        path Routes.Site.index >=> index
        pathRegex "(.*)\.(js)" >=> Files.browseHome
    ]