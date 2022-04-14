using Oqtane.Models;
using Oqtane.Modules;

namespace Oqtane.Demo31.Demo2
{
    public class ModuleInfo : IModule
    {
        public ModuleDefinition ModuleDefinition => new ModuleDefinition
        {
            Name = "Demo2",
            Description = "Demo2",
            Version = "1.0.0",
            ReleaseVersions = "1.0.0",
            Dependencies = "Oqtane.Demo31.Shared.Oqtane",
            PackageName = "Oqtane.Demo31"
        };
    }
}
