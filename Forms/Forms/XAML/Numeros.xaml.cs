using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.XAML
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Numeros : ContentPage
	{
		public int Numero { get; set; }
		public Numeros ()
		{
			InitializeComponent ();
			Numero = 0;
			Numerobtn.Text =Numero.ToString();
		}

		private void Button_Anterior(object sender, EventArgs e)
		{
			if (Numero <=1)
			{
				Numero = 0;
			}
			else
			{
				Numero--;
			}
			Numerobtn.Text = Numero.ToString();
		}

		private void Button_Siguiente(object sender, EventArgs e)
		{
			if (Numero >= 10)
			{
				Numero = 0;
			}
			else
			{
				Numero++;
			}
			Numerobtn.Text = Numero.ToString();
		}
	}
}