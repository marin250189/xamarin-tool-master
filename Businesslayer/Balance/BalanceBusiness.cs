using DataAccessLayer;
using DataAccessLayer.BalanceDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Balance
{
	public class BalanceBusiness : IBalanceBusiness
	{
		IBalanceRepository _balanceRepository;
		public BalanceBusiness(IBalanceRepository balanceRepository)
		{
			_balanceRepository = balanceRepository;
		}
		public async Task<Savings_balance> Create(Savings_balance savings_Balance)
		{
			try
			{
				if (savings_Balance != null)
				{
					var result = await _balanceRepository.Create(savings_Balance);
					return result;
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
			return null;
		}

		public async Task<IList<Savings_balance>> GetAll()
		{
			try
			{
				var result = await _balanceRepository.GetAll();
				return result;
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
			
		}

		public async Task<Savings_balance> Update(Savings_balance savings_Balance)
		{
			try
			{
				if (savings_Balance != null)
				{
					var result = await _balanceRepository.Update(savings_Balance);
					return result;
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
			return null;
		}
		public  bool Delete(Savings_balance savings_Balance)
		{
			try
			{
				if (savings_Balance != null)
				{
					 _balanceRepository.Delete(savings_Balance);
					
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
			return true;
		}
	}
}
