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
    public partial class Destinos : ContentPage
    {
        public IList<Destino> destinos { get; private set; }
        public Destinos()
        {
            InitializeComponent();
            destinos = new List<Destino>();
            destinos.Add(new Destino
            {
                Name = "Lima",
                Description = "Viaja a Lima con Travelling-Viajes a 50$",
                Url = "https://denomades.s3.us-west-2.amazonaws.com/blog/wp-content/uploads/2020/08/30162219/lima-peru-shutterstock_1047718252.jpg"
            }
            );
            destinos.Add(new Destino
            {
                Name = "Cusco",
                Description = "Viaja a Cusco con Travelling-Viajes a 60$",
                Url = "https://www.exploorperu.com/wp-content/uploads/2022/05/top-things-to-do-peru-exploor-peru-cusco.png"
            }
            );
            destinos.Add(new Destino
            {
                Name = "Arequipa",
                Description = "Viaja a Arequipa con Travelling-Viajes a 40$",
                Url = "https://media.vogue.mx/photos/5e5c4a5b25623100081c4370/16:9/w_1280,c_limit/Arequipa--paisaje.jpg"
            }
            );
            destinos.Add(new Destino
            {
                Name = "Puno",
                Description = "Viaja a Puno con Travelling-Viajes a 40$",
                Url = "https://noticias-pe.laiglesiadejesucristo.org/media/960x540/Aniversario-fundacion-Puno-2.jpg"
            }
            );
            destinos.Add(new Destino
            {
                Name = "Huancayo",
                Description = "Viaja a Huancayo con Travelling-Viajes a 30$",
                Url = "https://noticias-pe.laiglesiadejesucristo.org/media/960x540/Ciudad_de_huancayo.jpg"
            }
            );
            BindingContext = this;
        }
        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}