using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace FirebirdStudios
{
    public partial class StudioEquipment : ContentPage
    {
        private const string Url = "http://firebirdstudios.esy.es/test.json";
        //private ObservableCollection<TodoItem> _todoItem;
        private readonly HttpClient _client = new HttpClient();
        private ObservableCollection<Equipment> _equipment;

        public StudioEquipment()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var content = await _client.GetStringAsync(Url);
            var equipment = JsonConvert.DeserializeObject<List<Equipment>>(content);
            _equipment = new ObservableCollection<Equipment>(equipment);
            equipmentListView.ItemsSource = _equipment;

            base.OnAppearing();
        }


        private void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var equipment = e.SelectedItem as Equipment;
            if (equipment != null)
                Navigation.PushAsync(new EquipmentDetail(equipment));
        }
    }
}