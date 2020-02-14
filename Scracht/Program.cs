using Google.Cloud.Translation.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scracht
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.OutputEncoding = System.Text.Encoding.Unicode;
			TranslationClient client = TranslationClient.Create();
			var response = client.TranslateText("Hello World.", "ru");
			Console.WriteLine(response.TranslatedText);
		}
	}
}
