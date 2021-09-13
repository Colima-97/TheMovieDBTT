using System.Collections.Generic;
using Newtonsoft.Json;
using TheMovieDBTT.Models.API.Base;

namespace TheMovieDBTT.Models.API.Response
{
	public class TopRated
	{
		[JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("results")]
        public List<BaseApiResponse> Results { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("total_results")]
        public int TotalResults { get; set; }
	}
}
