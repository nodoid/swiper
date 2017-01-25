
using Android.App;
using Android.Content.PM;
using Android.OS;
using ScnViewGestures.Plugin.Forms.Droid.Renderers;
using Xamarin.Forms;

namespace swiper.Droid
{
    [Activity(Label = "swiper", Icon = "@drawable/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            ViewGesturesRenderer.Init();
            App.ScreenSize = new Size(Resources.DisplayMetrics.WidthPixels / Resources.DisplayMetrics.Density,
                Resources.DisplayMetrics.HeightPixels / Resources.DisplayMetrics.Density);
            LoadApplication(new App());
        }
    }
}

