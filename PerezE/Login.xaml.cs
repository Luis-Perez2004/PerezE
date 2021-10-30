using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PerezE
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var image = new Image { Source = "LogoE.png" };
        }

        private async void btnIngresar_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuraio.Text;
            string password = txtPassword.Text;

            if (usuario == "estudiante2021" & password == "uisrael2021")
            {
                await Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                DisplayAlert("Mensaje", "Usuario o contraseña invalidos", "OK");

                txtUsuraio.Text = "";
                txtPassword.Text = "";
                txtUsuraio.Focus();
            }
        }
    }
}
