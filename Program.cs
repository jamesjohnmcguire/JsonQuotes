using Newtonsoft.Json;
using System;

namespace JsonQuotes
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			// https://jsonlint.com/ claims this is valid json string
			string tester = "{ \"error\":\"InternalServerError\",\"error_description\":\"<!doctype html>\r\n<html lang=\"en\">\r\n\"}";

			ErrorMessage message = JsonConvert.DeserializeObject<ErrorMessage>(tester);
		}
	}
}
