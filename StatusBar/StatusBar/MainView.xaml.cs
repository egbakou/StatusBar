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
        }

        private void ShowStatusBarButton_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IStatusBar>().HideStatusBar();
        }

        private void HideStatusBarButton_Clicked(object sender, EventArgs e)
        {
            DependencyService.Get<IStatusBar>().ShowStatusBar();
        }
    }
}
