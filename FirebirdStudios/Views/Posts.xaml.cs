using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace FirebirdStudios
{
    public partial class Posts : ContentPage
    {
        private const string Url = "http://firebirdstudios.esy.es/wp-json/wp/v2/posts";
        private readonly HttpClient _client = new HttpClient();
        private ObservableCollection<Post> _posts;

        public Posts()
        {
            InitializeComponent();
            GetPosts();
        }

        private async void GetPosts()
        {
            var client = await _client.GetStringAsync(Url);
            var posts = JsonConvert.DeserializeObject<List<Post>>(client);
            _posts = new ObservableCollection<Post>(posts);
            postsListView.ItemsSource = _posts;
        }
    }
}