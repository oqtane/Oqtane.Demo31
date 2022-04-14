using Oqtane.Models;
using Oqtane.Modules;

namespace Oqtane.Demo31.Demo1
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Demo1",
            Description = "Demo1",
            Version = "1.0.0",
            ReleaseVersions = "1.0.0",
            Dependencies = "Oqtane.Demo31.Shared.Oqtane",
            PackageName = "Oqtane.Demo31" 
        };
    }
}
