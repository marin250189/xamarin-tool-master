using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Common
{
	public class Repository<T> : IRepository<T> where T : class
	{
		public async Task<T> Create(T entity)
		{
			try
			{
				if (entity != null)
				{
					using (VSOFTDBEntities ctx = new VSOFTDBEntities())
					{

						//T result = ctx.Set<T>().Add(entity);
						//await ctx.SaveChangesAsync();
						//return result;
					}
				}
			}
			catch (Exception Ex)
			{

				throw new Exception(Ex.Message);
			}
			return null;
		}

		public bool Delete(T entity)
		{
			throw new NotImplementedException();
		}

		public async Task<IList<T>> GetAll()
		{
			try
			{
				using (VSOFTDBEntities ctx = new VSOFTDBEntities())
				{
					List<T> result = ctx.Set<T>().ToList();
					return result;
				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}

			return null;
		}

		public T GetById(object Id)
		{
			try
			{
				if (Id != null && null != string.Empty)
				{
					using (VSOFTDBEntities ctx = new VSOFTDBEntities())
					{
						T result = ctx.Set<T>().Find(Id);
						return result;
					}
				}

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
			return null;
		}

		public T Update(T entity)
		{
			throw new NotImplementedException();
		}
	}
}
