using instaclone.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace instaclone
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class bob : ContentPage
    {
        public bob()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new AppShell();
        }
    }
}