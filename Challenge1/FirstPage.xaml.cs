using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Challenge1
{
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }
        async void Welcome(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
               
    }
}
