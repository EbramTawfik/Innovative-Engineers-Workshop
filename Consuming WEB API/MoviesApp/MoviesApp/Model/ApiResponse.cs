﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace MoviesApp.Model
{
	public class ApiResponse
	{
		[JsonProperty("page")]
		public int Page { get; set; }


		[JsonProperty("total_results")]
		public int TotalResults { get; set; }


		[JsonProperty("total_pages")]
		public int TotalPages { get; set; }


		[JsonProperty("results")]
		public List<Movie> Movies { get; set; }
	}
}
