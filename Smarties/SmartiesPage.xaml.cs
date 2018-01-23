using System;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Smarties
{
    public partial class SmartiesPage : ContentPage
    {

        ObservableCollection<Room> rooms = new ObservableCollection<Room>();


        public SmartiesPage()
        {
            InitializeComponent();

            listView.ItemsSource = rooms;

            rooms.Add(new Room { RoomName = "Room 1", Beacon = "Beacon1", Hue = "Hue1", Image  = "livingroom.png"});
            rooms.Add(new Room { RoomName = "Room 2", Beacon = "Bed Room Beacon", Hue = "Bed Room Hue" , Image = "bedroom.png"});
            rooms.Add(new Room { RoomName = "Room 3", Beacon = "Office Beacon", Hue = "Office Hue", Image = "office.png" });

        }

        async void OnButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RoomSettingsPage(rooms));
        }

        void OnTapGestureRecognizerTapped(object sender, EventArgs e)
        {
            Console.WriteLine(sender);

        }
    }
}
