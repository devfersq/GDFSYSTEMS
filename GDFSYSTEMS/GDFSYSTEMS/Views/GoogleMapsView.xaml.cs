using Plugin.Geolocator;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Maps;
using Xamarin.Forms.Xaml;

namespace GDFSYSTEMS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoogleMapsView : ContentPage
    {
        public Position _position;
        public GoogleMapsView()
        {
            try
            {
                InitializeComponent();
                GetPosition();
                BindingContext = this;

            }
            catch (Exception ex)
            {
                var error = ex.ToString();
            }
        }
        public async void GetPosition()
        {
            try
            {
                var locator = CrossGeolocator.Current;
                var myPosition = await locator.GetPositionAsync();
                locator.DesiredAccuracy = 50;
                _position = new Position(myPosition.Latitude, myPosition.Longitude);
                map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(myPosition.Latitude, myPosition.Longitude), Distance.FromMiles(1)));
                var defaultPin = new Pin { Type = PinType.Place, Label = "Dev Fersq", Address = "Necesito el trabajo.", Position = new Position(myPosition.Latitude, myPosition.Longitude) };
                map.Pins.Add(defaultPin);

            }
            catch (Exception ex)
            {
                var error = ex.ToString();
            }

        }
    }
}