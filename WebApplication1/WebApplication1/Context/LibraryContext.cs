using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Context
{
    public class LibraryContext:DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options): base(options) 
        {
        }
        public DbSet<Kitap> Kitap { get; set; }
        public DbSet<Gorevli> Gorevli { get; set;}
        public DbSet<Uyeler> Uyeler { get; set;}
        public DbSet<Yonetici> Yonetici { get; set;}
    }
}
