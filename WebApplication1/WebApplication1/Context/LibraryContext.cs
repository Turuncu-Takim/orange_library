using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Context
{
    public class LibraryContext:DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options): base(options) 
        {
        }
    }
}
