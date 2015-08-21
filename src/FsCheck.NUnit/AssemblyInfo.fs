﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("FsCheck.NUnit")>]
[<assembly: AssemblyProductAttribute("FsCheck.NUnit")>]
[<assembly: AssemblyDescriptionAttribute("Integrates FsCheck with NUnit")>]
[<assembly: AssemblyVersionAttribute("2.0.7")>]
[<assembly: AssemblyFileVersionAttribute("2.0.7")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "2.0.7"
