using System;
using Xamarin.Forms;

namespace FirebirdStudios
{
    public partial class FirebirdStudiosPage : ContentPage
    {
        public FirebirdStudiosPage()
        {
            InitializeComponent();
            Logo.Source = ImageSource.FromResource("FirebirdStudios.Images.Firebird-Logo-web.jpg");
        }

        private async void Skip_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Home());
        }

        private async void Login_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new LoginPage());
        }
    }
}