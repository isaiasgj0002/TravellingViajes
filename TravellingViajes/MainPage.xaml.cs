using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using TravellingViajes.Views;

namespace TravellingViajes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                Navigation.PushAsync(new Register());
            }
            catch(Exception ex)
            {
                DisplayAlert("Error", ex.Message, "Ok");
            }
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            var result = await App.Context.ObtenerUsuarioAsync(UsernameEntry.Text.Trim(), PasswordEntry.Text.Trim());
            if(result != null)
            {
                await Navigation.PushAsync(new MenuPrincipal());
            }
            else
            {
                await DisplayAlert("Error", "No se encontró al usuario", "Ok");
            }

        }
    }
}
