﻿namespace SES.Projects.Sanitarium.Chameleon.FactoryPlanning
{
    using System;
    using System.Windows;
    using Catel;
    using Gum.Controls;

    public class InvokeActionOnDataGridVisible
    {
        private readonly IDataGridInteraction _dataGridInteraction;
        private readonly Action<DataGrid> _actionOnVisible;

        public InvokeActionOnDataGridVisible(IDataGridInteraction dataGridInteraction, Action<DataGrid> actionOnVisible)
        {
            Argument.IsNotNull(() => dataGridInteraction);
            Argument.IsNotNull(() => actionOnVisible);

            _dataGridInteraction = dataGridInteraction;
            _actionOnVisible = actionOnVisible;
        }

        public void Execute()
        {
            _dataGridInteraction.ConfigureDataGrid(async dataGrid =>
            {
                if (!dataGrid.IsVisible)
                {
                    dataGrid.IsVisibleChanged += OnIsVisibleChanged;

                    return;
                }

                _actionOnVisible.Invoke(dataGrid);
            });
        }

        private async void OnIsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is not DataGrid dataGrid)
            {
                return;
            }

            if (!dataGrid.IsVisible)
            {
                return;
            }

            dataGrid.IsVisibleChanged -= OnIsVisibleChanged;

            _actionOnVisible.Invoke(dataGrid);
        }
    }
}
