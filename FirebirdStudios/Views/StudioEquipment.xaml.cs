using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Xamarin.Forms;
using Newtonsoft.Json;
using Microsoft.WindowsAzure.MobileServices;

namespace FirebirdStudios
{

	public partial class StudioEquipment : ContentPage
	{





		private const string Url = "http://firebirdstudios.esy.es/test.json";
		private ObservableCollection<Equipment> _equipment;
		//private ObservableCollection<TodoItem> _todoItem;
		private HttpClient _client = new HttpClient();
		public StudioEquipment()
		{
			InitializeComponent();

		}
		async protected override void OnAppearing()
		{

			var content = await _client.GetStringAsync(Url);
			var equipment = JsonConvert.DeserializeObject<List<Equipment>>(content);
			_equipment = new ObservableCollection<Equipment>(equipment);
			equipmentListView.ItemsSource = _equipment;

			base.OnAppearing();
		}



		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			var equipment = e.SelectedItem as Equipment;
			if (equipment != null)
			{
				Navigation.PushAsync(new EquipmentDetail(equipment));
			}

		}
	}
}
