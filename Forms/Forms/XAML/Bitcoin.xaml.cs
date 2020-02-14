using Forms.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.XAML
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Bitcoin : ContentPage
	{
		
		private MainPageViewModel mainPageViewModel;

		
		public Bitcoin()
		{
			mainPageViewModel = new MainPageViewModel();
			InitializeComponent();
			this.BindingContext = mainPageViewModel;


		}

		private void btnCalc_Clicked(object sender, EventArgs e)
		{
			if (mainPageViewModel.bitcoinModel!= null && mainPageViewModel.bitcoinModel.rates!= string.Empty && btcEntry.Text != string.Empty) 
			{
				decimal last = decimal.Parse(mainPageViewModel.bitcoinModel.rates, CultureInfo.InvariantCulture);
				decimal myBtcAmount = decimal.Parse(btcEntry.Text, CultureInfo.InvariantCulture);
				decimal result = last * myBtcAmount;
				lblCalcResult.Text = result.ToString();
			}
			
		}


	}

	

	

	
}