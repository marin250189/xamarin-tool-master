using Forms.Notifications;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.XAML
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPageMaster : ContentPage
	{
		public ListView ListView;
		INotificationManager notificationManager;
		int notificationNumber = 0;

		public MainPageMaster()
		{
			InitializeComponent();

			BindingContext = new MainPageMasterViewModel();
			ListView = MenuItemsListView;
			


		}

		

		class MainPageMasterViewModel : INotifyPropertyChanged
		{
			public ObservableCollection<MainPageMenuItem> MenuItems { get; set; }

			public MainPageMasterViewModel()
			{
				
				MenuItems = new ObservableCollection<MainPageMenuItem>(new[]
				{
					new MainPageMenuItem { Id = 0, Title = "Traductor",TargetType = typeof(Traductor) },
					new MainPageMenuItem { Id = 1, Title = "LCB Config", TargetType = typeof(DolarToday) },
					new MainPageMenuItem { Id = 2, Title = "Bitcoin" , TargetType = typeof(Bitcoin)},
					new MainPageMenuItem { Id = 3, Title = "Balance" , TargetType = typeof(Numeros)},
					new MainPageMenuItem { Id = 3, Title = "Wather" },

				});
			}

			#region INotifyPropertyChanged Implementation
			public event PropertyChangedEventHandler PropertyChanged;
			void OnPropertyChanged([CallerMemberName] string propertyName = "")
			{
				if (PropertyChanged == null)
					return;

				PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
			}
			#endregion
		}
	}
}