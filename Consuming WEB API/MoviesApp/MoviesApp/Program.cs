using MoviesApp.Model;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

namespace MoviesApp
{
	class Program
	{
		
		static void Main(string[] args)
		{
			Console.WriteLine("Please Ente Movie Namme : ");
			string mName = Console.ReadLine();

			HttpClient httpClient = new HttpClient();

			//Bakgound Thread  (1)
			//Task.Factory.StartNew(async() => {
			//	string json =await httpClient.GetStringAsync(Constants.MoviesUri);
			//	ApiResponse   response = JsonConvert.DeserializeObject<ApiResponse>(json);

			//	List<Movie> mList= response.Movies.Where(m=> m.Title.Contains(mName)).ToList();

			//	foreach (var item in mList)
			//	{
			//		Console.WriteLine(item.Title);
			//		Console.WriteLine(item.VoteAverage);
			//		Console.WriteLine("==================================================================");
			//	}

			//	Console.Read();
			//});

			getMovies(mName);


			Console.Read();



		}

		//Bakgound Thread (2)
		private static async Task getMovies(string mName)
		{
			HttpClient httpClient = new HttpClient();
			string json = await httpClient.GetStringAsync(Constants.MoviesUri);
			ApiResponse response = JsonConvert.DeserializeObject<ApiResponse>(json);

			List<Movie> mList = response.Movies.Where(m => m.Title.Contains(mName)).ToList();

			foreach (var item in mList)
			{
				Console.WriteLine(item.Title);
				Console.WriteLine(item.VoteAverage);
				Console.WriteLine("==================================================================");
			}

			Console.Read();

		}
	}
}
