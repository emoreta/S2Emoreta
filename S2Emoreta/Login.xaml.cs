using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace S2Emoreta
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }



        private async void btnAbrir_Clicked_1(object sender, EventArgs e)
        {
            string usuario = "estudiante2022";
            string contrasenia = "uisrael2022";

            if (txtUser.Text == usuario && txtPass.Text == contrasenia)
            {
                await Navigation.PushAsync(new PageDos(txtUser.Text, txtPass.Text));
            }
            else
            {
               await  DisplayAlert("Mensaje Alerta", "Usuario o Contraseña incorrecta", "Cerrar");
            }
        }
    }
}