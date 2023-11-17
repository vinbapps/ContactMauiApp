using Microsoft.Maui.Controls;
using System.Collections.ObjectModel;

namespace ContactMauiApp
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Contact> contacts = new ObservableCollection<Contact>();

        public MainPage()
        {
            InitializeComponent();
            ContactsListView.ItemsSource = contacts;
        }

        private void OnAddContactClicked(object sender, EventArgs e)
        {
            string name = NameEntry.Text;
            string address = AddressEntry.Text;
            string phoneNumber = PhoneNumberEntry.Text;

            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(address) && !string.IsNullOrEmpty(phoneNumber))
            {
                contacts.Add(new Contact { Name = name, Address = address, PhoneNumber = phoneNumber });

                // Clear input fields after adding a contact
                NameEntry.Text = string.Empty;
                AddressEntry.Text = string.Empty;
                PhoneNumberEntry.Text = string.Empty;
            }
            else
            {
                DisplayAlert("Error", "Please enter all fields", "OK");
            }
        }
    }

    public class Contact
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}
