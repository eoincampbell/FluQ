using System.Reflection;
using System.Runtime.InteropServices;

#if DEBUG 
[assembly: AssemblyConfiguration("Debug")]
#else
[assembly: AssemblyConfiguration("Release")]
#endif
[assembly: AssemblyCompany("Eoin Campbell")]
[assembly: AssemblyProduct("Qluent")]
[assembly: AssemblyCopyright("Copyright © 2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

[assembly: ComVisible(false)]

//IMPORTANT - Builds are configured on AppVeyor and will override these values
//check the AppVeyor.yml file in the solution items
[assembly: AssemblyVersion("0.1.0")]
[assembly: AssemblyFileVersion("0.1.0")]
[assembly: AssemblyInformationalVersion("0.1.0-beta")]

