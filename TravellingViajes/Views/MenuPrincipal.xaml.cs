using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravellingViajes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPrincipal : ContentPage
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        private void VerDestinos_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Destinos());
        }

        private void MisReservas_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ListaReservas());
        }

        private void NuevaReserva_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Reservar());
        }

    }
}