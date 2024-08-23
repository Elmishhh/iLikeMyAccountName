using MelonLoader;
using System.Reflection;

[assembly: AssemblyTitle(ILMSN.BuildInfo.Description)]
[assembly: AssemblyDescription(ILMSN.BuildInfo.Description)]
[assembly: AssemblyCompany(ILMSN.BuildInfo.Company)]
[assembly: AssemblyProduct(ILMSN.BuildInfo.Name)]
[assembly: AssemblyCopyright("Created by " + ILMSN.BuildInfo.Author)]
[assembly: AssemblyTrademark(ILMSN.BuildInfo.Company)]
[assembly: AssemblyVersion(ILMSN.BuildInfo.Version)]
[assembly: AssemblyFileVersion(ILMSN.BuildInfo.Version)]
[assembly: MelonInfo(typeof(ILMSN.ILMSNClass), ILMSN.BuildInfo.Name, ILMSN.BuildInfo.Version, ILMSN.BuildInfo.Author, ILMSN.BuildInfo.DownloadLink)]
[assembly: MelonColor()]

// Create and Setup a MelonGame Attribute to mark a Melon as Universal or Compatible with specific Games.
// If no MelonGame Attribute is found or any of the Values for any MelonGame Attribute on the Melon is null or empty it will be assumed the Melon is Universal.
// Values for MelonGame Attribute can be found in the Game's app.info file or printed at the top of every log directly beneath the Unity version.
[assembly: MelonGame(null, null)]