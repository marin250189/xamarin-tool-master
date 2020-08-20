using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Common
{
	public interface IRepository<T> where T : class
	{
		Task<T> Create(T entity);
		Task<T> Update(T entity);
		bool Delete(T entity);
		T GetById(object Id);
		Task<IList<T>> GetAll();

	}
}
