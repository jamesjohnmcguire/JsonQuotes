using Newtonsoft.Json;

namespace JsonQuotes
{
	public class ErrorMessage
	{

		[JsonProperty("error")]
		public string Error { get; set; }

		[JsonProperty("error_description")]
		public new string Description { get; set; }

	}
}
