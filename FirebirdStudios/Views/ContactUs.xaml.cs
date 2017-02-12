using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FirebirdStudios
{
	public partial class ContactUs : ContentPage
	{
		public ContactUs()
		{
			InitializeComponent();


		}

		void Handle_Clicked(object sender, System.EventArgs e)
		{
			Navigation.PushModalAsync(new NavigationPage(new Posts()));
		}

		void Email_Tapped(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("mailto:info@firebirdstudios.co.uk"));
		}

		void Phone_Tapped(object sender, System.EventArgs e)
		{
			Device.OpenUri(new Uri("tel:01179721830"));
		}
	}

}