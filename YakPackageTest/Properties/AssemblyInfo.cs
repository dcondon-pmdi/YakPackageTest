using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Rhino.PlugIns;

// Plug-in Description Attributes - all of these are optional.
// These will show in Rhino's option dialog, in the tab Plug-ins.
[assembly: PlugInDescription(DescriptionType.Address, "123 My Address")]
[assembly: PlugInDescription(DescriptionType.Country, "My Country")]
[assembly: PlugInDescription(DescriptionType.Email, "my@email.com")]
[assembly: PlugInDescription(DescriptionType.Phone, "555-5555")]
[assembly: PlugInDescription(DescriptionType.Fax, "555-5555")]
[assembly: PlugInDescription(DescriptionType.Organization, "MyCompany")]
[assembly: PlugInDescription(DescriptionType.UpdateUrl, "mywebsite.com/updates")]
[assembly: PlugInDescription(DescriptionType.WebSite, "mywebsite.com")]

// Icons should be Windows .ico files and contain 32-bit images in the following sizes: 16, 24, 32, 48, and 256.
[assembly: PlugInDescription(DescriptionType.Icon, "YakPackageTest.EmbeddedResources.plugin-utility.ico")]

// The following GUID is for the ID of the typelib if this project is exposed to COM
// This will also be the Guid of the Rhino plug-in
[assembly: Guid("83d4c40e-89ef-4354-ba13-4ba1f59d7014")]
