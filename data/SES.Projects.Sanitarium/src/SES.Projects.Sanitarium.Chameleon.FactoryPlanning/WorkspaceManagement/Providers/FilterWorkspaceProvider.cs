﻿namespace SES.Projects.Sanitarium.Chameleon.FactoryPlanning.WorkspaceManagement.Providers
{
    using System;
    using System.Threading.Tasks;
    using Catel;
    using Catel.IoC;
    using Catel.Services;
    using MethodTimer;
    using Orc.FilterBuilder;
    using Orc.WorkspaceManagement;

    public class FilterWorkspaceProvider : WorkspaceProviderBase
    {
        private readonly IFilterSchemeManager _filterSchemeManager;

        public FilterWorkspaceProvider(IWorkspaceManager workspaceManager,
            IDispatcherService dispatcherService, IFilterSchemeManager filterSchemeManager, IServiceLocator serviceLocator)
            : base(workspaceManager, dispatcherService, serviceLocator)
        {
            Argument.IsNotNull(() => filterSchemeManager);

            _filterSchemeManager = filterSchemeManager;
            _filterSchemeManager.Loaded += OnFilterSchemeManagerLoaded;
        }

        private void OnFilterSchemeManagerLoaded(object sender, EventArgs e)
        {
            var workspace = WorkspaceManager.Workspace;
            if (workspace is not null)
            {
#pragma warning disable AvoidAsyncVoid // Avoid async void
                DispatcherService.BeginInvoke(async () => await ApplyWorkspaceAsync(workspace));
#pragma warning restore AvoidAsyncVoid // Avoid async void
            }
        }

        public override async Task ProvideInformationAsync(IWorkspace workspace)
        {

        }

        [Time]
        public override async Task ApplyWorkspaceAsync(IWorkspace workspace)
        {

        }
    }
}
