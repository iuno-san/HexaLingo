using HexaLingo.Data;
using Microsoft.AspNetCore.Mvc;

namespace HexaLingo.Controllers
{
    public class BlogController : Controller
    {
        private readonly HexaLingoDbContext _context;

        public BlogController(HexaLingoDbContext context)
        {
            _context = context;
        }

        public IActionResult Post1()
        {
            return View();
        }
        public IActionResult Post2()
        {
            return View();
        }
        public IActionResult Post3()
        {
            return View();
        }
        public IActionResult Post4()
        {
            return View();
        }
    }
}
