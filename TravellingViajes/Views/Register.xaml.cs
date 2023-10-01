using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using TravellingViajes.Data;
using TravellingViajes.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravellingViajes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Register : ContentPage
    {
        public Register()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(UsernameEntry.Text) ||
                string.IsNullOrWhiteSpace(EmailEntry.Text) ||
                    string.IsNullOrWhiteSpace(PasswordEntry.Text))
            {
                await DisplayAlert("Error", "Completa todos los campos", "Ok");
                return;
            }
            else if (!EmailValidator.IsValidEmail(EmailEntry.Text.Trim()))
            {
                await DisplayAlert("Error", "Escriba un correo valido", "Ok");
                return;
            }
            try
            {
                var user = new User
                {
                    Nombre = UsernameEntry.Text.Trim(),
                    Email = EmailEntry.Text.Trim(),
                    Password = PasswordEntry.Text.Trim()
                };
                var result = await App.Context.RegisterUserAsync(user);
                if (result == 1)
                {
                    await Navigation.PushAsync(new MainPage());
                }
                else
                {
                    await DisplayAlert("Error", "Se produjo un error al registrarse", "Ok");
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "Ok");
            }
        }
    }
}