using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Model
{
	public class Tokens
	{
		[Key]
		public string Token { get; set; }
		public string RefreshToken { get; set; }
	}
}
