using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace appDeberSeman2
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string user,string pass)
        {
            InitializeComponent();
            lbTexto.Text = "Usuario : " + user + " " + "Password : " + pass;
        }


        private void txtNotaSegui1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNotaSegui1.Text))
            {
                if (Convert.ToDouble(txtNotaSegui1.Text) > 10)
                {
                    DisplayAlert("Advertencia", "Solo ingresar notas entre 0 y 10.", "Cerrar");
                }
            }
        }

        private void txtNotaSegui2_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtNotaSegui2.Text))
            {
                if (Convert.ToDouble(txtNotaSegui2.Text) > 10)
                {
                    DisplayAlert("Advertencia", "Solo ingresar notas entre 0 y 10.", "Cerrar");
                }
            }
        }

        private void txtExamen1_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtExamen1.Text))
            {
                if (Convert.ToDouble(txtExamen1.Text) > 10)
                {
                    DisplayAlert("Advertencia", "Solo ingresar notas entre 0 y 10.", "Cerrar");
                }
            }
        }

        private void txtExamen2_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtExamen2.Text))
            {
                if (Convert.ToDouble(txtExamen2.Text) > 10)
                {
                    DisplayAlert("Advertencia", "Solo ingresar notas entre 0 y 10.", "Cerrar");
                }
            }
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double notaParcial1 = (Convert.ToDouble(txtNotaSegui1.Text) * 0.30) + (Convert.ToDouble(txtExamen1.Text) * 0.20);
            double notaParcial2 = (Convert.ToDouble(txtNotaSegui2.Text) * 0.30) + (Convert.ToDouble(txtExamen2.Text) * 0.20);
            double resultado = notaParcial1 + notaParcial2;
            txtNotaParcial1.Text = Convert.ToString(notaParcial1);
            txtNotaParcial1.Text = Convert.ToString(notaParcial2);
            txtResultado.Text = Convert.ToString(resultado);
            if (resultado >= 7)
            {
                txtEstado.Text = "APROBADO";
            }else if(resultado>=5 && resultado <= 6.9)
            {
                txtEstado.Text = "COMPLEMENTARIO";
            }
            else if (resultado < 5)
            {
                txtEstado.Text = "REPROBADO";
            }
        }
    }
}
