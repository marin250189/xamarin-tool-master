using Businesslayer.Balance;
using Businesslayer.Currency;
using DataAccessLayer;
using DataAccessLayer.BalanceDAO;
using DataAccessLayer.Common;
using System;
using Unity;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Forms
{
	public partial class App : Application
	{
		public App()
		{
			
			InitializeComponent();
			RegisterService();
			MainPage = new XAML.MainPage();
		}

		private void RegisterService()
		{
			DependencyInjector.Register<IBalanceRepository, BalanceRepository>();
			DependencyInjector.Register<IBalanceBusiness, BalanceBusiness>();

			DependencyInjector.Register<ICurrencyBusiness, CurrencyBusiness>();
			DependencyInjector.Register<IRepository<Currencies>, Repository<Currencies>>();

		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
