using System;

namespace Thread.Feature.RichText.Tokens
{
	public class Token
	{
		public string Key { get; set; }
		public Func<string> Value { get; set; } 
	}
}