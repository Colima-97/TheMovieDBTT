using System.Collections.Generic;
using Newtonsoft.Json;
using TheMovieDBTT.Models.API.Response.Helpers;

namespace TheMovieDBTT.Models.API.Response
{
	public class Configuration
	{
		[JsonProperty("images")]
		public Images Images { get; set; }

		[JsonProperty("change_keys")]
		public List<string> ChangeKeys { get; set; }
	}
}
