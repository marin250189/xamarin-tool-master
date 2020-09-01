using DataAccessLayer;
using DataAccessLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Businesslayer.Currency
{
	public class CurrencyBusiness : ICurrencyBusiness
	{
		IRepository<Currencies> _repository;
		public CurrencyBusiness(IRepository<Currencies> repository)
		{
			_repository = repository;
		}
		public async Task<IList<Currencies>> GetAll()
		{
			try
			{
				var result = await _repository.GetAll();
				return result;
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
		}
	}
}
