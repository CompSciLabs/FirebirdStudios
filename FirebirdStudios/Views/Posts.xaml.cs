using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Xamarin.Forms;
using Newtonsoft.Json;
namespace FirebirdStudios
{
	public partial class Posts : ContentPage
	{
		private HttpClient _client = new HttpClient();
		private ObservableCollection<Post> _posts;
		private string Url = "http://firebirdstudios.esy.es/wp-json/wp/v2/posts";
		public Posts()
		{

			InitializeComponent();
			GetPosts();
		}
		async void GetPosts()
		{
			var client = await _client.GetStringAsync(Url);
			var posts = JsonConvert.DeserializeObject<List<Post>>(client);
			_posts = new ObservableCollection<Post>(posts);
			postsListView.ItemsSource = _posts;
		}
	}
}
