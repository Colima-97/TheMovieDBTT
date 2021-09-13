using System;
using Newtonsoft.Json;

namespace TheMovieDBTT.Models.API.Response.Helpers
{
	public class Dates
	{
		[JsonProperty("maximum")]
		public DateTime Maximum { get; set; }
		
		[JsonProperty("minimum")]
		public DateTime Minimum { get; set; }
	}
}
