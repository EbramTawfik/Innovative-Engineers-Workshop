using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApp.Model
{
	public class Movie
	{
		[JsonProperty("vote_average")]
		public double VoteAverage { get; set; }

		[JsonProperty("title")]
		public string Title { get; set; }
	}
}
