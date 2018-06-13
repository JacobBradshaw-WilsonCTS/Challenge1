using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Challenge1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void Added(object sender, EventArgs e)
        {
            DisplayAlert("Added", "Song has been added", "OK");
            Addsong.Text = "Added";

        }
    }
}
