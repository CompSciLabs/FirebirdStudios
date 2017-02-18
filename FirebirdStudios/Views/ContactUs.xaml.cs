using System;
using Xamarin.Forms;

namespace FirebirdStudios
{
    public partial class ContactUs : ContentPage
    {
        public ContactUs()
        {
            InitializeComponent();
        }

        private void Handle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new Posts()));
        }

        private void Email_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("mailto:info@firebirdstudios.co.uk"));
        }

        private void Phone_Tapped(object sender, EventArgs e)
        {
            Device.OpenUri(new Uri("tel:01179721830"));
        }
    }
}