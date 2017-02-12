using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FirebirdStudios
{
	public partial class Home : TabbedPage
	{
		public Home()
		{
			InitializeComponent();
			var booking = new ToolbarItem();
			booking.Icon = "plus.png";
			booking.Clicked += newBooking;


		}

		async void newBooking(object sender, EventArgs e)
		{
			await Navigation.PushModalAsync(new NavigationPage(new MakeBooking()));
		}
	}
}
