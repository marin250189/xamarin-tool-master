using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class Savings_Type
	{
		[Key]
		public int TYPEID { get; set; }
		public string VALUE { get; set; }
		public string DESCRIPTION { get; set; }

		public ICollection<Savings_balance> savings_Balances { get; set; }
	}
}
