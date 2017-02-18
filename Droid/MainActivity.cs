using Android.App;
using Android.Content.PM;
using Android.OS;
using FFImageLoading.Forms.Droid;
using Microsoft.WindowsAzure.MobileServices;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace FirebirdStudios.Droid
{
    [Activity(Label = "FirebirdStudios.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            CurrentPlatform.Init();
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            Forms.Init(this, bundle);
            //Xamarin.FormsMaps.Init(this, bundle);
            CachedImageRenderer.Init();
            LoadApplication(new App());
        }
    }
}