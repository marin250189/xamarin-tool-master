using Forms.Notifications;
using Forms.ViewModels;
using Google.Apis.Services;
using Google.Apis.Translate.v2;
using Google.Cloud.Translation.V2;
using Newtonsoft.Json;
using RavSoft.GoogleTranslator;
using System;
using System.Net.Http;
using System.Web;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;

namespace Forms
{
	public partial class MainPage : ContentPage
	{
		public MainPageViewModel mainPageViewModel { get; set; }
		
		public MainPage()
		{
			InitializeComponent();
			
		}

		

		protected override void OnAppearing()
		{
			base.OnAppearing();
			
			mainPageViewModel = new MainPageViewModel();
			this.BindingContext = mainPageViewModel;
		}






		
	}
}
