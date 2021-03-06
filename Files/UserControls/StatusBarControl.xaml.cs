﻿using Files.View_Models;
using Windows.UI.Xaml.Controls;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace Files.UserControls
{
    public sealed partial class StatusBarControl : UserControl
    {
        public SettingsViewModel AppSettings => App.AppSettings;
        public SelectedItemPropertiesViewModel SelectedItemPropertiesViewModel => App.SelectedItemPropertiesViewModel;

        public StatusBarControl()
        {
            this.InitializeComponent();
        }
    }
}