using GDFSYSTEMS.ViewModels.Base;
using GDFSYSTEMS.Views.MenuHamburguesa;
using Plugin.Connectivity;
using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace GDFSYSTEMS.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand IngresarCommand { get; set; }
        public MainPageViewModel()
        {
            try
            {
                this.IngresarCommand = new Command(async () => await IngresarCommandOnclick());

            }
            catch (Exception ex)
            {
                var error = ex.ToString();
            }

        }
        async Task IngresarCommandOnclick()
        {
            try
            {
                if (CrossConnectivity.Current.IsConnected)
                {
                    if (String.IsNullOrWhiteSpace(User_Entry))
                    {
                        await Application.Current.MainPage.DisplayAlert("El campo correo", "Es obligatorio.", "OK");
                    }
                    else
                    {
                        bool isEmail = Regex.IsMatch(User_Entry, @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z", RegexOptions.IgnoreCase);
                        if (!isEmail)
                        {
                            await Application.Current.MainPage.DisplayAlert("El campo correo", "Es incorrecto, revíse e intente de nuevo.", "OK");
                        }
                        else
                        {
                            if (String.IsNullOrWhiteSpace(Password_Entry))
                            {
                                await Application.Current.MainPage.DisplayAlert("El campo contraseña", "Es obligatorio.", "OK");
                            }
                            else
                            {
                                MasterDetailPageView view = new MasterDetailPageView();

                                await App.Current.MainPage.Navigation.PushAsync(view);
                            }
                        }
                    }
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("UPS", "Ocurrió un error, verifique su internet", "OK");
                }


            }
            catch (Exception ex)
            {
                var error = ex.ToString();
            }
        }


        #region Validaciones Campo Login
        private string _User_Entry;
        public string User_Entry
        {
            get { return _User_Entry; }
            set { _User_Entry = value; OnPropertyChanged(); }
        }

        private string _Password_Entry;
        public string Password_Entry
        {
            get { return _Password_Entry; }
            set { _Password_Entry = value; OnPropertyChanged(); }
        }

        #endregion
    }
}
