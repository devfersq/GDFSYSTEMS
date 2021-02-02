
using GDFSYSTEMS.Models.WebApi;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GDFSYSTEMS.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WebApiView : ContentPage
    {
        private const string url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _Client = new HttpClient();
        private ObservableCollection<PostModel> _post;
        public WebApiView()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            var content = await _Client.GetStringAsync(url);
            var post = JsonConvert.DeserializeObject<List<PostModel>>(content);
            _post = new ObservableCollection<PostModel>(post);
            Post_List.ItemsSource = _post;
            base.OnAppearing();
        }
    }
}