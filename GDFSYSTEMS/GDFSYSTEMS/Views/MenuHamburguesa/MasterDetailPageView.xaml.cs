using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GDFSYSTEMS.Views.MenuHamburguesa
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterDetailPageView : MasterDetailPage
    {
        public List<MasterDetailPageViewMasterMenuItem> menuList { get; set; }
        public MasterDetailPageView()
        {
            InitializeComponent();
            menuList = new List<MasterDetailPageViewMasterMenuItem>();

            // Adding menu items to menuList and you can define title ,page and icon
            menuList.Add(new MasterDetailPageViewMasterMenuItem() { Title = "Google Maps", Icon = "Ico_Inicio.png", TargetType = typeof(GoogleMapsView) });
            menuList.Add(new MasterDetailPageViewMasterMenuItem() { Title = "Servicio Api", Icon = "Icon_Api.png", TargetType = typeof(WebApiView) });
            menuList.Add(new MasterDetailPageViewMasterMenuItem() { Title = "Informacion App", Icon = "Ico_MiInformacion.png", TargetType = typeof(MiInformacionView) });
            //menuList.Add(new MasterDetailPageViewMasterMenuItem() { Title = "Salir", Icon = "Ico_Cerrar.png", TargetType = typeof(PruebaView) });

            // Setting our list to be ItemSource for ListView in MainPage.xaml
            navigationDrawerList.ItemsSource = menuList;

            // Initial navigation, this can be used for our home page
            Detail = new NavigationPage((Page)Activator.CreateInstance(typeof(GoogleMapsView)));
        }
        private void OnMenuItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var item = (MasterDetailPageViewMasterMenuItem)e.SelectedItem;
            Type page = item.TargetType;

            Detail = new NavigationPage((Page)Activator.CreateInstance(page));
            IsPresented = false;
        }
     
    }
}