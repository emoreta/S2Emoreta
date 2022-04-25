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
    public partial class PageDos : ContentPage
    {
        double resultadoUno;
        double resultadoDos;
        double resultadoFinal;
        int maxValue = 10;
        public PageDos(string usuario,string contrasenia)
        {
            InitializeComponent();
			lblUsuario.Text = usuario;
			lblNotaUNo.Text = "0";
            LblNotaDos.Text = "0";
            txtNotaSeguimientoUno.Text = "";
            txtNotaExamenUno.Text = "";
            txtNotaSeguimientoDos.Text = "";
            txtNotaExamenDos.Text = "";
        }
		private void btnNotaUNo_Clicked(object sender, EventArgs e)
		{
			try
			{
				if (txtNotaSeguimientoUno.Text != "" && txtNotaExamenUno.Text != "")
				{
					if (Convert.ToDouble(txtNotaSeguimientoUno.Text) > maxValue || Convert.ToDouble(txtNotaExamenUno.Text) > maxValue)
					{
						DisplayAlert("Mensaje Alerta", "Los valores no pueden ser mayores a 10", "Cerrar");
					}
					else
					{
						double datoSeguimientoUno = Convert.ToDouble(txtNotaSeguimientoUno.Text);
						double datoExamenUno = Convert.ToDouble(txtNotaExamenUno.Text);
						resultadoUno = (datoSeguimientoUno * 0.3) + (datoExamenUno * 0.2);
						lblNotaUNo.Text = resultadoUno.ToString();
					}

				}
				else
				{
					DisplayAlert("Mensaje Alerta", "Se deben ingresar los campos Seguimiento Uno y Examen Uno", "Cerrar");
				}
			}
			catch (Exception ex)
			{
				DisplayAlert("Error", ex.Message, "cerrar");

			}
		}

		private void btnNotaDos_Clicked(object sender, EventArgs e)
		{
			try
			{
				if (txtNotaSeguimientoDos.Text != "" && txtNotaExamenDos.Text != "")
				{
					if (Convert.ToDouble(txtNotaSeguimientoDos.Text) > maxValue || Convert.ToDouble(txtNotaExamenDos.Text) > maxValue)
					{
						DisplayAlert("Mensaje Alerta", "Los valores no pueden ser mayores a 10", "Cerrar");
					}
					else
					{
						double datoSeguimientoDos = Convert.ToDouble(txtNotaSeguimientoDos.Text);
						double datoExamenDos = Convert.ToDouble(txtNotaExamenDos.Text);
						resultadoDos = (datoSeguimientoDos * 0.3) + (datoExamenDos * 0.2);
						LblNotaDos.Text = resultadoDos.ToString();
						resultadoFinal = resultadoUno + resultadoDos;
						LblNotaFinal.Text = resultadoFinal.ToString();


						if (resultadoFinal >= 7)
						{
							LblEstado.Text = "APROBADO";
						}
						else if (resultadoFinal >= 5 && resultadoFinal <= 6.9)
						{
							LblEstado.Text = "COMPLEMENTARIO";
						}
						else if (resultadoFinal < 5)
						{
							LblEstado.Text = "REPROBADO";
						}
						else
						{

						}
					}
				}
				else
				{
					DisplayAlert("Mensaje Alerta", "Se deben ingresar los campos Seguimiento Dos y Examen Dos", "Cerrar");
				}

			}
			catch (Exception ex)
			{
				DisplayAlert("Error", ex.Message, "cerrar");

			}
		}
	}
}