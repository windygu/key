#region Using directives

using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System;
using DrectSoft.FrameWork.Plugin;

#endregion

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("DrectSoft.Core")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyProduct("DrectSoft.Framework")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Revision and Build Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("1.0.0.1")]
[assembly:AssemblyFileVersion("1.0.0.0")]
[assembly: System.CLSCompliant(true)]
[assembly: ComVisible(false)]
[assembly: ReliabilityContract(Consistency.MayCorruptProcess, Cer.None)]
[assembly:SecurityPermission(SecurityAction.RequestMinimum)]
[assembly: BizPlugin("Core", BizPluginType.Implement,true)]
[assembly: BizPlugin("Core", BizPluginType.Interface,true)]
[assembly: log4net.Config.XmlConfigurator(ConfigFile = @"LogApp.config", ConfigFileExtension = "config", Watch = true)]
