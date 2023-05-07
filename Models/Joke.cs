using System;
namespace JokeAPPMVC.Models
{
	public class Joke
	{
		public int Id { get; set; }
		public string JokeName { get; set; } = string.Empty;
		public string JokeAnswer { get; set; } = "";
		public string CreateUser { get; set; } = "";
	}
}

