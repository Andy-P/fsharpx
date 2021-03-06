﻿#if INTERACTIVE
#load "../FSharpx.TypeProviders/SetupTesting.fsx"
SetupTesting.generateSetupScript __SOURCE_DIRECTORY__
#load "__setup__.fsx"
#endif

open System
open System.IO
open FSharpx.TypeProviders.Helper
open FSharpx.TypeProviders.AppSettingsTypeProvider

let (++) a b = Path.Combine(a, b)
let resolutionFolder = __SOURCE_DIRECTORY__ ++ ".." ++ ".." ++ "tests" ++ "FSharpx.TypeProviders.AppSettings.Tests"

generate typedAppSettings resolutionFolder [| "Test.App.Config" |] 
|> prettyPrint 
|> Console.WriteLine
