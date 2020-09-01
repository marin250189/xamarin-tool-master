using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Currency
{
	public interface ICurrencyBusiness
	{
		Task<IList<Currencies>> GetAll();
	}
}
