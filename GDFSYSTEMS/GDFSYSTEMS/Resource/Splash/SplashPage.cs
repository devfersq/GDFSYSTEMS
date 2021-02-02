using System;
using Xamarin.Forms;

namespace GDFSYSTEMS.Resource.Splash
{
    public class SplashPage : ContentPage
    {
        Image splashImage;
        AbsoluteLayout sub;
        public SplashPage()
        {
            try
            {
                NavigationPage.SetHasNavigationBar(this, false);

                sub = new AbsoluteLayout();

                splashImage = new Image
                {
                    Source = "Logo_GFD.png",
                    WidthRequest = 500,
                    HeightRequest = 300
                };
                AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
                AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));
                sub.Children.Add(splashImage);
                this.BackgroundColor = Color.FromHex("#FFFFFF");
                this.Content = sub;
            }catch(Exception ex)
            {
                var error = ex.ToString();
            }
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await splashImage.ScaleTo(1, 2000);
            //var navigationService = Locator.Instance.Resolve<INavigationService>();
            //  await navigationService.NavigateToAsync<MainPageViewModel>();
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
