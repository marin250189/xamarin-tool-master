using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class Currencies
	{
		[Key]
		public int CURRENCYID { get; set; }
		public string VALUE { get; set; }
		public string DESCRIPTION { get; set; }

		



	}
}
