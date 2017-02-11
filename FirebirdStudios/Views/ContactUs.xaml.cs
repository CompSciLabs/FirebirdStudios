using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace FirebirdStudios
{
	public partial class ContactUs : ContentPage
	{
		public ContactUs()
		{
			InitializeComponent();
			generateMap();

		}

		void generateMap()
		{
			var position = new Position(51.4325818, -2.5422303);
			var pin = new Pin
			{
				Position = position,
				Type = PinType.Place,
				Label = "FireBird Studios",
				Address = "21- 23 Emery Road, Bristol BS4 5PF"
			};
			var map = new Map(MapSpan.FromCenterAndRadius(position, Distance.FromMiles(0.3)))
			{
				IsShowingUser = true,
				HeightRequest = 200,
				WidthRequest = 300
			};
			map.Pins.Add(pin);
			var stack = new StackLayout();
			stack.Children.Add(map);
			Content = stack;
		}
	}

}