using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PerezE
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        double vtotal = 1800;
        double pmensual = 0;
        double aux = 0;
        double cinicial = 0;
        string login = "";
        public Registro(string usuario)
        {
            InitializeComponent();
            lbusuario.Text = "Usuario conectado: " + usuario;
            login = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            try
            {
                
                cinicial = Convert.ToDouble(VI.Text);
                
                if (cinicial < 0 | cinicial > 1800)
                {
                    VI.Text = "";
                    VI.Focus();
                    DisplayAlert("Alerta", "Valores ingresados no pueden ser mayores a 1800 o inferiores a 0", "OK");
                }
                else
                {
                    aux = vtotal - cinicial;

                    pmensual = (double)(aux / 3 + vtotal * 0.05);
                    PM.Text = Convert.ToString(Math.Round(pmensual,2));
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("Mensaje de advertencia", ex.Message, "OK");
            }
        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            string nombre = Nombre.Text;
            double MTotal = pmensual * 3 + cinicial;

            DisplayAlert("Mensaje", "Elemento guardado con exito...", "OK");

            await Navigation.PushAsync(new Resumen(login,nombre,MTotal));
        }
    }
}