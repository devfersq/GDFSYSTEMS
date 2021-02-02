
using Android.App;
using Android.Content.PM;
using Android.OS;
using System;

namespace GDFSYSTEMS.Droid
{
    [Activity(Label = "GDFSYSTEMS", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize )]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            try 
            {
                TabLayoutResource = Resource.Layout.Tabbar;
                ToolbarResource = Resource.Layout.Toolbar;

                base.OnCreate(savedInstanceState);
                #region Google Maps
                Xamarin.FormsMaps.Init(this, savedInstanceState);
                Plugin.CurrentActivity.CrossCurrentActivity.Current.Init(this, savedInstanceState);
                #endregion
                Xamarin.Essentials.Platform.Init(this, savedInstanceState);
                global::Xamarin.Forms.Forms.Init(this, savedInstanceState);

                LoadApplication(new App());
            }
            catch (Exception ex)
            {
                var error = ex.ToString();
            }
           
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Android.Content.PM.Permission[] grantResults)
        {
            Plugin.Permissions.PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}