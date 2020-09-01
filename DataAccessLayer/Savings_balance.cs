using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
	public class Savings_balance: BaseEntity
	{
		public int ID { get; set; }
		public string DESCRIPTION { get; set; }
		public decimal AMOUNT { get; set; }
		public int TYPE { get; set; }

		[ForeignKey("TYPE")]
		public  virtual  Savings_Type Savings_Type { get; set; }

		private int _currency;
		public int CURRENCY 
		{ get =>_currency; 
			set { 
				_currency = value; OnPropertyChanged("CURRENCY"); 
			} 
		}

		private Currencies _currencies;
		[ForeignKey("CURRENCY")]		
		public virtual  Currencies Currencies 
		{ get =>_currencies;
			set 
			{
				
				_currencies = value;
				
				OnPropertyChanged("Currencies"); 
			} 
		}
		
		
	}
}
