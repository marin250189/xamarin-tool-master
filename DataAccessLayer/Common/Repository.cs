﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.Query.Internal;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

						ctx.Set<T>().Add(entity);
						await ctx.SaveChangesAsync();
						return entity;
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
			try
			{
				using (VSOFTDBEntities ctx = new VSOFTDBEntities())
				{

					ctx.Set<T>().Remove(entity);
					ctx.SaveChanges();
					
				}
				

			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
			return true;
		}

		public async Task<IList<T>> GetAll()
		{
			try
			{
				using (VSOFTDBEntities ctx = new VSOFTDBEntities())
				{
					
					List<T> result =  ctx.Set<T>().ToList();
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

		public async Task<T> Update(T entity)
		{
			try
			{
				using (VSOFTDBEntities context = new VSOFTDBEntities())
				{
					context.Entry(entity).State = EntityState.Modified;
					context.ChangeTracker.DetectChanges();
					var tt = context.ChangeTracker.HasChanges();
					context.SaveChanges();
					return entity;

				}
			}
			catch (Exception ex)
			{

				throw new Exception(ex.Message);
			}
			
		}
		
		
	}
}
