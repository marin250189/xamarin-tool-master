﻿using Forms.ViewModels;
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
		public BalanceViewModel balancePageViewModel { get; set; }
		public Numeros ()
		{
			balancePageViewModel = new BalanceViewModel();
			InitializeComponent ();
			this.BindingContext = balancePageViewModel;

		}

		
			

		
	}
}