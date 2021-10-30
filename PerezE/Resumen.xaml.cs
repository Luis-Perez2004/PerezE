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
    public partial class Resumen : ContentPage
    {
        public Resumen(string login, string nombre, double total)
        {
            InitializeComponent();
            lbusuario.Text = "Usuario conectado: " + login;
            Nombre.Text = nombre;
            Tpagar.Text = Convert.ToString(total);
        }
    }
}