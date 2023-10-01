using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravellingViajes.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravellingViajes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reservar : ContentPage
    {
        public Reservar()
        {
            InitializeComponent();
            OriginPicker.SelectedIndex = 0;
            DestinationPicker.SelectedIndex = 0;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                var reserva = new Reserva
                {
                    LugarOrigen = OriginPicker.SelectedItem?.ToString(),
                    LugarDestino = DestinationPicker.SelectedItem?.ToString(),
                    FechaIda = DepartureDate.Date.ToString(),
                    FechaVuelta = ReturnDate.Date.ToString()
                };
                var result = await App.Context.RegisterRservationAsync(reserva);
                if (result == 1)
                {
                    await DisplayAlert("Éxito", "Tu reserva se realizó con éxito, enviaremos detalles de pago a tu correo electrónico", "Ok");
                }
                else
                {
                    await DisplayAlert("Error", "Se produjo un error al reservar", "Ok");
                }
            }
            catch(Exception ex)
            {
                await DisplayAlert("Error", "Se produjo un error al reservar: "+ex.Message, "Ok");
            }
        }
    }
}