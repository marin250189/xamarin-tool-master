using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.XAML
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DolarToday : ContentPage
	{
		public DolarToday()
		{
			InitializeComponent();
			if (!String.IsNullOrEmpty(AuthKey) && !String.IsNullOrEmpty(SecrectKey))
			{
				secretTxt.Text = SecrectKey;
				keyTxt.Text = AuthKey;
			}

		}
		private static ISettings AppSettings =>
	     CrossSettings.Current;

		public static string AuthKey
		{
			get => AppSettings.GetValueOrDefault(nameof(AuthKey), string.Empty);
			set => AppSettings.AddOrUpdateValue(nameof(AuthKey), value);
		}
		public static string SecrectKey
		{
			get => AppSettings.GetValueOrDefault(nameof(SecrectKey), string.Empty);
			set => AppSettings.AddOrUpdateValue(nameof(SecrectKey), value);
		}

		private void addSettingsBtn_Clicked(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(keyTxt.Text) && !String.IsNullOrEmpty(secretTxt.Text))
			{
				SecrectKey = secretTxt.Text;
				AuthKey = keyTxt.Text;
			}
		}
	}
}