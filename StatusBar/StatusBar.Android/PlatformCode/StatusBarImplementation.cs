using Android.App;
using Android.Views;
using Plugin.CurrentActivity;
using StatusBar.Droid.PlatformCode;
using StatusBar.Interfaces;
using Xamarin.Forms;

[assembly: Dependency(typeof(StatusBarImplementation))]
namespace StatusBar.Droid.PlatformCode
{
    public class StatusBarImplementation : IStatusBar
    {
        public StatusBarImplementation()
        {

        }

        WindowManagerFlags _originalFlags;

        public void HideStatusBar()
        {
            Activity activity = CrossCurrentActivity.Current.Activity;
            var attrs = activity.Window.Attributes;
            _originalFlags = attrs.Flags;
            attrs.Flags |= WindowManagerFlags.Fullscreen;
            activity.Window.Attributes = attrs;
        }

        public void ShowStatusBar()
        {
            var activity = CrossCurrentActivity.Current.Activity;
            var attrs = activity.Window.Attributes;
            attrs.Flags = _originalFlags;
            activity.Window.Attributes = attrs;
        }
    }
}