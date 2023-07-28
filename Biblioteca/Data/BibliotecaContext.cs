using Microsoft.EntityFrameworkCore;

namespace Biblioteca.Data
{
	public class BibliotecaContext: DbContext
	{
	   public BibliotecaContext(DbContextOptions<BibliotecaContext> options) : base(options) { 
		
		

		}
	}
}
