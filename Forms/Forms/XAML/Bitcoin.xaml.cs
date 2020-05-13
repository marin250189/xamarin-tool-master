using Forms.Model;
using Forms.ViewModels;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Plugin.Settings;
using Plugin.Settings.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Forms.XAML
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Bitcoin : ContentPage
	{
		
		private MainPageViewModel mainPageViewModel;
		private HttpClient _client;
		private static ISettings AppSettings =>
		 CrossSettings.Current;

		public Bitcoin()
		{
			_client = new HttpClient();
			
			mainPageViewModel = new MainPageViewModel();
			InitializeComponent();
			this.BindingContext = mainPageViewModel;
		    getLcoalBitcoinBalance();

		}

		private async Task getLcoalBitcoinBalance() 
		{
			string authKey = AppSettings.GetValueOrDefault("AuthKey","");
			string secrectKey = AppSettings.GetValueOrDefault("SecrectKey", "");


			if (!String.IsNullOrEmpty(authKey) && !String.IsNullOrEmpty(secrectKey))
			{
				long nonce = DateTime.Now.Ticks;
				string api_endpoint = "/api/wallet/";
				string url = "https://localbitcoins.com/api/wallet/";
				string get_or_post_params_urlencoded = "";
				string hmac_key = authKey;
				string message = nonce.ToString() + hmac_key + api_endpoint + get_or_post_params_urlencoded;
				byte[] message_bytes = Encoding.UTF8.GetBytes(message);
				byte[] key = Encoding.UTF8.GetBytes(secrectKey);
				HMACSHA256 hmac = new HMACSHA256(key);
				byte[] hashValue = hmac.ComputeHash(message_bytes);
				var converted = BitConverter.ToString(hashValue).Replace("-", "").ToUpper();
				try
				{
					_client.DefaultRequestHeaders.Add("Apiauth-Key", authKey);
					_client.DefaultRequestHeaders.Add("Apiauth-Nonce", nonce+"");
					_client.DefaultRequestHeaders.Add("Apiauth-Signature", converted);
					var response = await _client.GetAsync(url);
					if (response.IsSuccessStatusCode)
					{
						var content = await response.Content.ReadAsStringAsync();
						var settings = new JsonSerializerSettings
						{
							NullValueHandling = NullValueHandling.Ignore,
							MissingMemberHandling = MissingMemberHandling.Ignore,
							Formatting = Formatting.Indented
							
						};						
						Forms.Model.LCB rootObject = JsonConvert.DeserializeObject<Forms.Model.LCB>(content, settings);
						
						balanceTxt.Text =  rootObject.Data.Total.Balance != null ? rootObject.Data.Total.Balance : string.Empty ;
						btcEntry.Text = rootObject.Data.Total.Balance != null ? rootObject.Data.Total.Balance : string.Empty;
					}
				}
				catch (Exception ex)
				{

					balanceTxt.Text = "Error: La autenticacion con localbitcoin falló";
				}

			}
			else
			{
				balanceTxt.Text = "Error: Las Credenciales no han sido definidas.";
			}
			
		}

		private void btnCalc_Clicked(object sender, EventArgs e)
		{
			if (mainPageViewModel.bitcoinModel!= null && mainPageViewModel.bitcoinModel.rates!= string.Empty && btcEntry.Text != string.Empty) 
			{
				decimal last = decimal.Parse(mainPageViewModel.bitcoinModel.rates, CultureInfo.InvariantCulture);
				decimal myBtcAmount = decimal.Parse(btcEntry.Text, CultureInfo.InvariantCulture);
				decimal result = last * myBtcAmount;
				lblCalcResult.Text = String.Format("{0:0.00}", result);
			}
			
		}

		private void btnCalcRate_Clicked(object sender, EventArgs e)
		{
			if (mainPageViewModel.bitcoinModel != null && mainPageViewModel.bitcoinModel.rates != string.Empty && VEStxt.Text != string.Empty)
			{
				decimal last = decimal.Parse(mainPageViewModel.bitcoinModel.rates, CultureInfo.InvariantCulture);
				decimal vesRate = decimal.Parse(VEStxt.Text, CultureInfo.InvariantCulture);
				decimal result = last * vesRate;
				lblrateResult.Text = String.Format("{0:n}", result); 
			}
		}

		private void btnCalcGanancia_Clicked(object sender, EventArgs e)
		{
			if (mainPageViewModel.bitcoinModel != null && mainPageViewModel.bitcoinModel.rates != string.Empty && VEStxt.Text != string.Empty && lblrateResult.Text != string.Empty && Gananciatxt.Text != string.Empty)
			{
				decimal vesRate = decimal.Parse(lblrateResult.Text, CultureInfo.InvariantCulture);
				int gananciaxciento = int.Parse(Gananciatxt.Text);
				decimal result = (vesRate * gananciaxciento)/100;
				lblGananciaResult.Text = String.Format("{0:n}", result);
				string compra = String.Format("{0:n}", (vesRate - result));
				lblCompra.Text = "Compra :" + compra;

				string venta = String.Format("{0:n}", (vesRate + result));
				lblVenta.Text = "Venta :" + venta;
			}
		}
	}

	

	

	
}