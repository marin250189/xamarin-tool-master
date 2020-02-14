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
	public partial class DolarToday : ContentPage
	{
		public DolarToday()
		{
			InitializeComponent();
			DolarTodayImg.Source = "https://dxj1e0bbbefdtsyig.woldrssl.net/custom/rate2.jpg?nc=1";

		}
	}
}