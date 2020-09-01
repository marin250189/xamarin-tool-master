using Android.Media;
using Businesslayer.Balance;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Windows.Input;
using Xamarin.Forms;
using System.Collections.ObjectModel;
using Android.Views;
using Businesslayer.Currency;
using Forms.Model;

namespace Forms.ViewModels
{
	public class BalanceViewModel : BaseViewModel
	{
		private ObservableCollection<Savings_balance> savings_Balances;
		private string _usd_balance;
		private string _eur_balance;
		private string _descriptionEntry;
		private string _montoEntry;
		private IList<Currencies> _currencies;
		private Savings_balance _selectedBalance;
		private int selectedCurrency;
		public ICommand AddBalanceCommand { get; set; }
		public ICommand UpdateBalanceCommand { get; set; }

		public ICommand DeleteBalanceCommand { get; set; }
		public BalanceViewModel()
		{
			PopulateCurrencies();
			GetAllBalances();
			
			
			AddBalanceCommand = new Command(async () =>
			{
				IsBusy = true;
				await Task.Delay(2000);
				await AddBalance();
				
				IsBusy = false;
			});
			UpdateBalanceCommand = new Command(async () =>
			{
				IsBusy = true;
				await Task.Delay(2000);
				await UpdateBalance();
				
				IsBusy = false;
			});
			DeleteBalanceCommand = new Command(async () =>
			{
				IsBusy = true;
				await Task.Delay(2000);
				await DeleteBalance();
				
				IsBusy = false;
			});

		}

		public Savings_balance SelectedBalance { get=>_selectedBalance; set { _selectedBalance = value; OnPropertyChanged("SelectedBalance"); } }

		public ObservableCollection<Savings_balance> Savings_Balances
		{
			get => savings_Balances;
			set
			{
				savings_Balances = value;
				OnPropertyChanged("Savings_Balances");
			}
		}

		public string DescriptionEntry { get => _descriptionEntry; set { _descriptionEntry = value; OnPropertyChanged("DescriptionEntry"); } }
		public string MontoEntry { get => _montoEntry; set { _montoEntry = value; OnPropertyChanged("MontoEntry"); } }

		public IList<Currencies> CurrenciesList { get => _currencies; set { _currencies = value; OnPropertyChanged("CurrenciesList"); } }
		public int SelectedCurrency { get => selectedCurrency; set { selectedCurrency = value; OnPropertyChanged("SelectedCurrency"); } }

		public string Usd_balance { get => _usd_balance; set { _usd_balance = value; OnPropertyChanged("Usd_balance"); } }

		public string Eur_balance { get => _eur_balance; set { _eur_balance = value; OnPropertyChanged("Eur_balance"); } }

		public async Task UpdateBalance()
		{
			try
			{

				if (SelectedBalance != null)
				{
					IBalanceBusiness balanceBusiness = DependencyInjector.Retrieve<IBalanceBusiness>();
					SelectedBalance.CURRENCY = CurrenciesList[SelectedBalance.CURRENCY].CURRENCYID;

					await balanceBusiness.Update(SelectedBalance);

					SelectedBalance.CURRENCY--;

				}


			}
			catch (Exception ex)
			{

				throw;
			}
		}
		public async Task DeleteBalance()
		{
			try
			{
				
				if (SelectedBalance != null)
				{
					IBalanceBusiness balanceBusiness = DependencyInjector.Retrieve<IBalanceBusiness>();

					 balanceBusiness.Delete(SelectedBalance);
					savings_Balances.Remove(SelectedBalance);

				}


			}
			catch (Exception ex)
			{

				throw;
			}
		}

		public async Task AddBalance()
		{
			try
			{
				if (!String.IsNullOrWhiteSpace(DescriptionEntry) && !String.IsNullOrWhiteSpace(MontoEntry))
				{
					IBalanceBusiness balanceBusiness = DependencyInjector.Retrieve<IBalanceBusiness>();
					Savings_balance entity = new Savings_balance
					{
						DESCRIPTION = DescriptionEntry,
						AMOUNT = Decimal.Parse(MontoEntry),
						CURRENCY = CurrenciesList[SelectedCurrency].CURRENCYID
				};
					await balanceBusiness.Create(entity);
					savings_Balances.Add(entity);
					
					

				}
				
				
			}
			catch (Exception ex)
			{

				throw;
			}
		}

		public async Task PopulateCurrencies() 
		{
			try
			{
				//	var modalPage = new ContentPage();
				//	modalPage.Title = "Loading..";
				//	await Application.Current.MainPage.Navigation.PushModalAsync(modalPage);
				await Task.Delay(500);
				ICurrencyBusiness currencyBusiness = DependencyInjector.Retrieve<ICurrencyBusiness>();
				CurrenciesList = await Task.FromResult(currencyBusiness.GetAll().Result.ToList());
				SelectedCurrency = 0;
				
				//await Application.Current.MainPage.Navigation.PopModalAsync( true);
			}
			catch (Exception ex)
			{

				throw;
			}
		}
		public async Task GetAllBalances()
		{


			try
			{
				savings_Balances = new ObservableCollection<Savings_balance>();
				IsBusy = true;
				await Task.Delay(1000);
				decimal usd_amount = 0;
				decimal eur_amount = 0;
				IBalanceBusiness balanceBusiness = DependencyInjector.Retrieve<IBalanceBusiness>();
				ICurrencyBusiness currencyBusiness = DependencyInjector.Retrieve<ICurrencyBusiness>();
				var CurrenciesList = await Task.FromResult( currencyBusiness.GetAll().Result.ToList());				
				
				var balanceList = await Task.FromResult(balanceBusiness.GetAll().Result.ToList());
				foreach (var item in balanceList)
				{
					//item.Currencies = currencyBusiness.GetAll().Result.FirstOrDefault(a => a.CURRENCYID == item.CURRENCY);
					item.CURRENCY--;
					savings_Balances.Add(item);
					switch (CurrenciesList[item.CURRENCY].VALUE)
					{
						case CurrencyConstants.USD: 
							usd_amount += item.AMOUNT;
							break;
						case CurrencyConstants.EUR: 
							eur_amount += item.AMOUNT;
							break;

						default:
							break;
					}

					
					
					
				}
				Usd_balance = String.Format("USD balance : {0}", usd_amount);
				Eur_balance = String.Format(" EUR balance : {0}", eur_amount);



				IsBusy = false;


			}
			catch (Exception ex)
			{

				IsBusy = false;
				
			}

		}
	}
}
