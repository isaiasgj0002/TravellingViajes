using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravellingViajes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetalleReserva : ContentPage
    {
        public int idseleccionado;
        public string lugarorigenseleccionado, lugardestinoseleccionado, fechaidaseleccionada, fechavueltaseleccionada;

        public DetalleReserva(int idRes,string LugarOrigen,string LugarDestino,string FechaIda,string FechaVuelta)
        {
            InitializeComponent();
            idseleccionado = idRes;
            lugarorigenseleccionado = LugarOrigen;
            lugardestinoseleccionado=LugarDestino;
            fechaidaseleccionada = FechaIda;
            fechavueltaseleccionada = FechaVuelta;
        }
        protected override void OnAppearing()
        {
            txt_lugar_origen.Text = lugarorigenseleccionado;
            txt_lugar_destino.Text = lugardestinoseleccionado;
            txt_fecha_ida.Text = fechaidaseleccionada;
            txt_fecha_vuelta.Text = fechavueltaseleccionada;
            base.OnAppearing();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var respuesta = await DisplayAlert("Aviso", "¿Esta seguro que desea eliminar esta reserva?", "Si", "No");
            if (respuesta)
            {
                try
                {
                    var result = await App.Context.DeleteReservationAsync(new Models.Reserva
                    {
                        Id = idseleccionado,
                        LugarOrigen = lugarorigenseleccionado,
                        LugarDestino = lugardestinoseleccionado,
                        FechaIda = fechaidaseleccionada,
                        FechaVuelta = fechavueltaseleccionada
                    });
                    if (result == 1)
                    {
                        await DisplayAlert("Mensaje", "Se cancelo la reserva", "OK");
                    }
                }
                catch(Exception ex)
                {
                    await DisplayAlert("Error", ex.Message, "Ok");
                }
            }
        }
    }
}