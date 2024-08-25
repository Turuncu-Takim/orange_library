using Microsoft.AspNetCore.Mvc;
using WebApplication1.Context;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class KitapKontrol : Controller

    {
        private readonly LibraryContext _context;
        public KitapKontrol(LibraryContext context)
        {
            _context = context;
        }

        [HttpPost]
        public ActionResult<Kitap> Create(Kitap kitap)
        {
            _context.Kitap.Add(kitap);
            _context.SaveChanges();
            return Ok(kitap);
        }
    }
}
