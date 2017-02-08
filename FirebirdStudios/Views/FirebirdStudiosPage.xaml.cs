using System;
using Xamarin.Forms;

namespace FirebirdStudios
{
	public partial class FirebirdStudiosPage : ContentPage
	{
		public FirebirdStudiosPage()
		{
			InitializeComponent();
			logo.Source = ImageSource.FromResource("FirebirdStudios.Images.Firebird-logo-web.jpg");
		}

		async void Skip_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new Home());

		}

		async void Login_Clicked(object sender, System.EventArgs e)
		{
			await Navigation.PushAsync(new LoginPage());
		}
	}
}
