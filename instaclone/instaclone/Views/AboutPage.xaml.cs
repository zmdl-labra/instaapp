using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace instaclone.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();

            ListView.ItemsSource = new List<contacts> {
                new contacts {Name = "Mosh", ImageUrl = "https://st3.depositphotos.com/1037987/15097/i/600/depositphotos_150975580-stock-photo-portrait-of-businesswoman-in-office.jpg", Status = "your friend mosh is on facebook"},
                new contacts {Name = "John", ImageUrl = "https://www.incimages.com/uploaded_files/image/1920x1080/getty_481292845_77896.jpg", Status = "greet john a happy birthday"},
                new contacts {Name = "Bob", ImageUrl = "https://thumbs.dreamstime.com/b/close-up-portrait-nice-person-bristle-show-finger-okey-sign-isolated-pink-color-background-203466939.jpg", Status = "bob is live on facebook"}
            };
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var contact = e.SelectedItem as contacts;
            if (contact.Name == "Bob")
            {
                App.Current.MainPage = new bob();
            }
            else if (contact.Name == "Mosh")
            {
                App.Current.MainPage = new mosh();
            }
            else
            {
                App.Current.MainPage = new john();
            }
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}