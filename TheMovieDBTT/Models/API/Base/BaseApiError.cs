using System;
using Newtonsoft.Json;

namespace TheMovieDBTT.Models.API.Base
{
	public class BaseApiError
	{
		[JsonProperty("status_message")]
		public string StatusMessage { get; set; }

		[JsonProperty("status_code")]
		public int StatusCode { get; set; }
	}
}
