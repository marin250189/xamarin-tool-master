using Forms.ViewModels;
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
	public partial class MainPageDetail : ContentPage
	{
		public WeatherPageViewModel weatherPageViewModel { get; set; }
		public MainPageDetail()
		{
			weatherPageViewModel = new WeatherPageViewModel();
			InitializeComponent();
			this.BindingContext = weatherPageViewModel;
		}

		
	}
}