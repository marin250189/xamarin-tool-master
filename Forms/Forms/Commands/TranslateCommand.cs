using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Forms.Commands
{
	public class TranslateCommand : ICommand
	{
		public TranslateCommand()
		{

		}

		public event EventHandler CanExecuteChanged;

		public bool CanExecute(object parameter)
		{
			throw new NotImplementedException();
		}

		public void Execute(object parameter)
		{
			
		}

	}
}
