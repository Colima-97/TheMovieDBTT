using System.Collections.Generic;
using Newtonsoft.Json;
using TheMovieDBTT.Models.API.Base;
using TheMovieDBTT.Models.API.Response.Helpers;

namespace TheMovieDBTT.Models.API.Response
{
	public class Upcoming
	{
		[JsonProperty("page")]
		public int Page { get; set; }

		[JsonProperty("results")]
		public List<BaseApiResponse> Results { get; set; }

		[JsonProperty("dates")]
		public Dates Dates { get; set; }

		[JsonProperty("total_pages")]
		public int TotalPages { get; set; }

		[JsonProperty("total_results")]
		public int TotalResults { get; set; }
	}
}
