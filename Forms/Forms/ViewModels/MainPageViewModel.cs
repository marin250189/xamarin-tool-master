using Forms.Commands;
using Forms.Model;
using Forms.Notifications;
using Newtonsoft.Json;
using RavSoft.GoogleTranslator;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Forms.ViewModels
{
	public class MainPageViewModel : BaseViewModel
	{
		HttpClient _client;		
		public ICommand TranslateCommand { get; set; }
		public ICommand RateCommand { get; set; }
		public ICommand CalculateCommand { get; set; }
		private string _entryToBeTranslated;
		private string _entryTranslationResult;
		private IList<Language> _idiomas;
		private int _destinationLanguagePickerIndex;
		private int _sourceLanguagePickerIndex;
		private BitcoinModel _bitcoinModel;
		

		public BitcoinModel bitcoinModel
		{
			get => _bitcoinModel;
			set
			{
				_bitcoinModel = value;
				OnPropertyChanged("bitcoinModel");
			}
		}



		public IList<Language> Idiomas { get => _idiomas; set => _idiomas = value; }
		public int SourceLanguagePickerIndex
		{
			get => _sourceLanguagePickerIndex;
			set
			{
				_sourceLanguagePickerIndex = value;
				OnPropertyChanged("SourceLanguagePickerIndex");
			}
		}
		public int DestinationLanguagePickerIndex
		{
			get => _destinationLanguagePickerIndex;
			set
			{
				_destinationLanguagePickerIndex = value;
				OnPropertyChanged("DestinationLanguagePickerIndex");
			}
		}
		public string EntryToBeTranslated
		{
			get => _entryToBeTranslated;
			set
			{
				_entryToBeTranslated = value;
				OnPropertyChanged("EntryToBeTranslated");
			}
		}
		public string EntryTranslationResult
		{
			get => _entryTranslationResult;
			set
			{
				_entryTranslationResult = value;
				OnPropertyChanged("EntryTranslationResult");
			}
		}

		



		public MainPageViewModel()
		{
			
			_idiomas = FillLanguageList();
			_client = new HttpClient();
			SourceLanguagePickerIndex = 0;
			DestinationLanguagePickerIndex = 1;
			RateCommand = new Command( async ()=> 
			{
				bitcoinModel = await getRate();
			});

			CalculateCommand = new Command( async () =>
			{
				
			});
			TranslateCommand = new Command(async
			 () =>
			{
				IsBusy = true;
				await Task.Delay(2000);
			    
				string sourceText = EntryToBeTranslated;
				string sourceLanguage = Idiomas[SourceLanguagePickerIndex].Code;
				string destinationLanguage = Idiomas[DestinationLanguagePickerIndex].Code;
				EntryTranslationResult = await BtnTranslate(sourceText, sourceLanguage, destinationLanguage);
				IsBusy = false;
			});

		}

		
		async Task<BitcoinModel> getRate()
		{
			
			var url = "https://www.bitstamp.net/api/ticker/";
			var response = await _client.GetAsync(url);
			if (response.IsSuccessStatusCode)
			{
				var content = await response.Content.ReadAsStringAsync();
				Bitstamp rootObject = JsonConvert.DeserializeObject<Bitstamp>(content);
				BitcoinModel bn = new BitcoinModel
				{
					Currency = "USD",
					rates = rootObject.last		

				};
				return bn;				
			}			
			return new BitcoinModel { Currency = "USD", rates = "N/A"};
		}
		
		private List<Language> FillLanguageList()
		{
			List<Language> langueageList = new List<Language>();

			langueageList.Add(new Language { Code = "es", Name = "Español" });
			langueageList.Add(new Language { Code = "pt", Name = "Portugues" });
			langueageList.Add(new Language { Code = "en", Name = "Inglés" });
			langueageList.Add(new Language { Code = "fr", Name = "Frances" });
			langueageList.Add(new Language { Code = "it", Name = "Italiano" });
			langueageList.Add(new Language { Code = "ja", Name = "Japones" });



			return langueageList;
		}
		private async Task<string> BtnTranslate(string sourceText, string sourceLanguage, string destinationLanguage)
		{


			try
			{
				if (!string.IsNullOrEmpty(sourceText))
				{

					Translator t = new Translator();
					var translationresult = await t.TranslateAsync(sourceText, sourceLanguage, destinationLanguage);

					return translationresult;
				}
				else
				{
					return string.Empty;
				}

			}
			catch (Exception ex)
			{

				return "Ha ocurrido un error.";
			}
		}
	}
}
