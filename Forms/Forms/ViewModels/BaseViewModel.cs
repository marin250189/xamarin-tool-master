using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Forms.ViewModels
{
	public class BaseViewModel : INotifyPropertyChanged
	{
		private bool _isBusy;

		public bool IsBusy
		{	get => _isBusy;
			set {
				_isBusy = value;
				
				OnPropertyChanged("IsBusy");
				}
		}
		public event PropertyChangedEventHandler PropertyChanged;
		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

	}
}
