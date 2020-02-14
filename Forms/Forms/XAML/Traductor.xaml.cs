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
	public partial class Traductor : ContentPage
	{
		public MainPageViewModel mainPageViewModel { get; set; }
		public Traductor ()
		{
			mainPageViewModel = new MainPageViewModel();
			InitializeComponent ();
			this.BindingContext = mainPageViewModel;
		}
	}
}