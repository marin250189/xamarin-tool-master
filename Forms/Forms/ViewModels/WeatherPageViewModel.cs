using Forms.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Forms.ViewModels
{
	public class WeatherPageViewModel : BaseViewModel
	{
		HttpClient _client;
		public ICommand WeatherCommand { get; set; }

		private string _iconUrl;
		private string _city;
		private WeatherModel _weatherModel;
		private string _temp;

		public string Temp
		{
			get => _temp;
			set
			{
				_temp = value;
				OnPropertyChanged("Temp");
			}
		}

		public WeatherModel WeatherModels
		{
			get => _weatherModel;
			set
			{
				_weatherModel = value;
				OnPropertyChanged("WeatherModels");
			}
		}

		public string City 
		{
			get => _city; 
			set 
			{ _city = value;
				OnPropertyChanged("City");
			}
		}

		public string iconUrl
		{
			get => _iconUrl;
			set
			{
				_iconUrl = value;
				OnPropertyChanged("iconUrl");
			}
		}

		

		public WeatherPageViewModel()
		{
			_client = new HttpClient();
			City = "Caracas";
			WeatherCommand = new Command(async
			 () =>
			{
				IsBusy = true;
				await Task.Delay(2000);
				WeatherModels = await getTemperature();
				iconUrl = WeatherModels.iconUrl;
				Temp = WeatherModels.Temp;

				IsBusy = false;
			});
		}

		async Task<WeatherModel> getTemperature()
		{

			var url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid=c1f0597c4ca3b55216da325cddcf00fe&units=Metric",City);
			var response = await _client.GetAsync(url);
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				Temperatures rootObject = JsonConvert.DeserializeObject<Temperatures>(content);
				WeatherModel weather = new WeatherModel
				{
					iconUrl = string.Format("http://openweathermap.org/img/wn/{0}@2x.png", rootObject.Weather[0].Icon),
					Temp = string.Format("{0} °С temperature from {1} to {2}°С ", rootObject.Main.Temp, rootObject.Main.TempMin, rootObject.Main.TempMax)  


				};
				return weather;
			}
			return new WeatherModel { iconUrl=""};
		}
	}
}
