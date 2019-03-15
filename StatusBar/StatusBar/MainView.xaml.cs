using StatusBar.Interfaces;
using System;
using Xamarin.Forms;

namespace StatusBar
{
    public partial class MainView : ContentPage
    {
        public MainView()
        {
            InitializeComponent();
            ShowStatusBarButton.IsEnabled = false;
        }
       
        private void HideStatusBarButton_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IStatusBar>().HideStatusBar();
            HideStatusBarButton.IsEnabled = false;
            ShowStatusBarButton.IsEnabled = true;
        }

        private void ShowStatusBarButton_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IStatusBar>().ShowStatusBar();
            HideStatusBarButton.IsEnabled = true;
            ShowStatusBarButton.IsEnabled = false;
        }
    }
}
