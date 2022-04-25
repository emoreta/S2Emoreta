using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace S2Emoreta
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

		}

		private async void btnAbrir_Clicked(object sender, EventArgs e)
		{
			string usuario = "estudiante2022";
			string contrasenia = "uisrael2022";

			if (txtUser.Text == usuario && txtPass.Text == contrasenia)
			{
				await Navigation.PushAsync(new PageDos(txtUser.Text, txtPass.Text));
			}
			else
			{
				await DisplayAlert("Mensaje Alerta", "Usuario o Contraseña incorrecta", "Cerrar");
			}
		}
	}
}
