
using Android.App;
using Android.Content.PM;
using Android.Media;
using Android.OS;

namespace KidsPictures.Droid
{
    [Activity(Label = "KidsPictures.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        MediaPlayer _player; 

        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);

            LoadApplication(new App());

            _player = MediaPlayer.Create(this, Resource.Raw.vMireZhivotnyh);
            _player.Start();
        }
    }
}
