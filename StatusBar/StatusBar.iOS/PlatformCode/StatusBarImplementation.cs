using StatusBar.Interfaces;
using StatusBar.iOS.PlatformCode;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(StatusBarImplementation))]
namespace StatusBar.iOS.PlatformCode
{
    public class StatusBarImplementation : IStatusBar
    {
        public StatusBarImplementation()
        {

        }

        public void HideStatusBar()
        {
            UIApplication.SharedApplication.StatusBarHidden = true;
        }

        public void ShowStatusBar()
        {
            UIApplication.SharedApplication.StatusBarHidden = false;
        }
    }
}