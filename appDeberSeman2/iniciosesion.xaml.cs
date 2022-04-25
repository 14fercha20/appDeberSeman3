using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace appDeberSeman2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class iniciosesion : ContentPage
    {
        public iniciosesion()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            if (txtContrasenia.Text == "uisrael2022" && txtUsuario.Text == "estudiante2022")
            {
                await Navigation.PushAsync(new MainPage(txtUsuario.Text, txtContrasenia.Text));
            }
            else
            {
                DisplayAlert("Alerta", "usuario o contraseña erróneos", "cerrar");
            }

        }
    }
}