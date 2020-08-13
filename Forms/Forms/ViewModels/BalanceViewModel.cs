using Android.Media;
using Businesslayer.Balance;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.ViewModels
{
	public class BalanceViewModel : BaseViewModel
	{
		private List<Savings_balance> savings_Balances;
		public BalanceViewModel()
		{
			savings_Balances = GetAllBalances();

		}

		public List<Savings_balance> Savings_Balances 
		{
			get => savings_Balances;
			set 
			{ 
				savings_Balances = value;
				OnPropertyChanged("Savings_Balances");
			} 
		}

		public  List<Savings_balance> GetAllBalances() 
		{
			List<Savings_balance> result = new List<Savings_balance>();
			try
			{
				IBalanceBusiness balanceBusiness = DependencyInjector.Retrieve<IBalanceBusiness>();
				result =  balanceBusiness.GetAll().Result.ToList();

			}
			catch (Exception ex)
			{

				throw;
			}
			return result;
		}
	}
}
