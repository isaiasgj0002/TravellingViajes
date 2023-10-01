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
    public partial class ListaReservas : ContentPage
    {
        public ListaReservas()
        {
            InitializeComponent();
            CargarReservas();
        }

        private async void CargarReservas()
        {
            List<Reserva> reservas = await App.Context.GetAllReservationsAsync();
            reservasListView.ItemsSource = reservas;
        }

        private void reservasListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var obj = (Reserva)e.SelectedItem;
            var id = obj.Id.ToString();
            var LugarOrigen = obj.LugarOrigen.ToString();
            var LugarDestino = obj.LugarDestino.ToString();
            var FechaIda = obj.FechaIda.ToString();
            var FechaVuelta = obj.FechaVuelta.ToString();
            int idRes = Convert.ToInt32(id);
            try
            {
                Navigation.PushAsync(new DetalleReserva(idRes, LugarOrigen, LugarDestino, FechaIda, FechaVuelta));
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}