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

namespace Forms.ViewModels
{
	public class BalanceViewModel : BaseViewModel
	{
		private ObservableCollection<Savings_balance> savings_Balances;
		private string _descriptionEntry;
		private string _montoEntry;
		public ICommand AddBalanceCommand { get; set; }
		public ICommand UpdateBalanceCommand { get; set; }

		public ICommand DeleteBalanceCommand { get; set; }
		public BalanceViewModel()
		{
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

		public Savings_balance SelectedBalance { get; set; }

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

		public async Task UpdateBalance()
		{
			try
			{

				if (SelectedBalance != null)
				{
					IBalanceBusiness balanceBusiness = DependencyInjector.Retrieve<IBalanceBusiness>();

					await balanceBusiness.Update(SelectedBalance);


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
		public async Task GetAllBalances()
		{


			try
			{
				IBalanceBusiness balanceBusiness = DependencyInjector.Retrieve<IBalanceBusiness>();
				savings_Balances = new ObservableCollection<Savings_balance>( await Task.FromResult(balanceBusiness.GetAll().Result.ToList()));


			}
			catch (Exception ex)
			{

				throw;
			}

		}
	}
}
