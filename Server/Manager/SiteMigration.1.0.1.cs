using Oqtane.Extensions;
using Oqtane.Infrastructure;
using Oqtane.Models;
using Oqtane.Repository;
using Oqtane.Shared;
using System.Collections.Generic;

namespace Oqtane.Demo31.SiteMigration
{
    [SiteMigration("localhost:44357", "01.00.01")]
    public class ExampleSiteMigration : ISiteMigration
    {
        private readonly ISiteRepository _siteRepository;

        public ExampleSiteMigration(ISiteRepository siteRepository)
        {
            _siteRepository = siteRepository;
        }

        void ISiteMigration.Up(Site site, Alias alias)
        {
            List<PageTemplate> pageTemplates = new List<PageTemplate>();
            
            pageTemplates.Add(new PageTemplate
            {
                Name = "Demo",
                Parent = "", // root
                Order = 9, // last
                Path = "demo",
                Icon = Icons.Lightbulb,
                IsNavigation = true,
                IsPersonalizable = false,
                PagePermissions = new List<Permission>
                {
                    new Permission(PermissionNames.View, RoleNames.Everyone, true),
                    new Permission(PermissionNames.View, RoleNames.Admin, true),
                    new Permission(PermissionNames.Edit, RoleNames.Admin, true)
                }.EncodePermissions(),
                PageTemplateModules = new List<PageTemplateModule>
                {
                    new PageTemplateModule
                    {
                        ModuleDefinitionName = "Oqtane.Demo31.Demo1, Oqtane.Demo31.Client.Oqtane", 
                        Title = "Demo1", 
                        Pane = PaneNames.Admin,
                        ModulePermissions = new List<Permission>
                        {
                            new Permission(PermissionNames.View, RoleNames.Everyone, true),
                            new Permission(PermissionNames.View, RoleNames.Admin, true),
                            new Permission(PermissionNames.Edit, RoleNames.Admin, true)
                        }.EncodePermissions(),
                        Content = ""
                    },
                    new PageTemplateModule
                    {
                        ModuleDefinitionName = "Oqtane.Demo31.Demo2, Oqtane.Demo31.Client.Oqtane", 
                        Title = "Demo2", 
                        Pane = PaneNames.Admin,
                        ModulePermissions = new List<Permission>
                        {
                            new Permission(PermissionNames.View, RoleNames.Everyone, true),
                            new Permission(PermissionNames.View, RoleNames.Admin, true),
                            new Permission(PermissionNames.Edit, RoleNames.Admin, true)
                        }.EncodePermissions(),
                        Content = ""
                    }
                }
            });

            _siteRepository.CreatePages(site, pageTemplates);
        }

        void ISiteMigration.Down(Site site, Alias alias)
        {
            // not implemented
        }
    }
}
