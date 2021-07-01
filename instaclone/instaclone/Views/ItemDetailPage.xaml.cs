using instaclone.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace instaclone.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}