using GDFSYSTEMS.ViewModels.Base;

namespace GDFSYSTEMS.ViewModels
{
    public class GoogleMapsViewModel: BaseViewModel
    {
        public string Title { get; set; }
        public GoogleMapsViewModel()
        {
            Title = "Google Maps";
        }
    }
}
