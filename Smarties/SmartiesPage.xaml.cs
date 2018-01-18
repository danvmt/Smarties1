using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Smarties
{
    public partial class SmartiesPage : ContentPage
    {

        ObservableCollection<ListItem> listItems = new ObservableCollection<ListItem>();


        public SmartiesPage()
        {
            InitializeComponent();

            listView.ItemsSource = listItems;

            listItems.Add(new ListItem { Text = "Room 1", Detail = "Living Room", Image  = "livingroom.png" });
            listItems.Add(new ListItem { Text = "Room 2", Detail = "Bed Room" , Image = "bedroom.png"});
            listItems.Add(new ListItem { Text = "Room 3", Detail = "Office", Image = "office.png" });

        }

        public void AddItem(string itemText, string detailText, string ImageUrl)
        {
            listItems.Add(new ListItem { Text = itemText, Detail = detailText, Image = ImageUrl });
        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewRoomPage());
        }
    }
}
