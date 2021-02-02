using GDFSYSTEMS.Resource.Splash;
using System;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace GDFSYSTEMS
{
    public partial class App : Application
    {
        private PermissionStatus permissionNetwork = PermissionStatus.Unknown;
        private PermissionStatus permissionLocation = PermissionStatus.Unknown;
       
        public App()
        {
            try 
            {
                InitializeComponent();
               // _ = GetPermissions();
                MainPage = new NavigationPage(new SplashPage());
            }
            catch (Exception ex) 
            {
                var error = ex.ToString();

            }
           
        }
        private async Task GetPermissions()
        {
            permissionNetwork = await Permissions.CheckStatusAsync<Permissions.NetworkState>();
            permissionLocation = await Permissions.CheckStatusAsync<Permissions.LocationAlways>();
            _ = permissionNetwork != PermissionStatus.Granted ? await Permissions.RequestAsync<Permissions.NetworkState>() : permissionNetwork;
            _ = permissionLocation != PermissionStatus.Granted ? await Permissions.RequestAsync<Permissions.LocationAlways>() : permissionNetwork;
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
