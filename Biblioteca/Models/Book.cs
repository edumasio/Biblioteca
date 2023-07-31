using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biblioteca.Models
{
	[Table("books")]
	public class Book
	{
		public int Id { get; set; }
		[Required]
		public string? Title { get; set; }	
		public string? ISBN { get; set; }
		public Publisher? Publisher { get; set; }

		public ICollection<Author>?  Authors { get; set; } 

				


	}
}
