using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace Businesslayer.Balance
{
	public interface IBalanceBusiness
	{
		Task<IList<Savings_balance>> GetAll();
		Task<Savings_balance> Create(Savings_balance savings_Balance);
	}
}
