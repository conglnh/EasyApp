using System.Linq;
using EasyAqq.WebApp.Model;
using Microsoft.AspNetCore.Mvc;

namespace EasyAqq.WebApp.Controller
{
    [ApiController]
    public class BookController : Microsoft.AspNetCore.Mvc.Controller
    {

        public readonly ApplicationDbContext _db;

        
        public BookController(ApplicationDbContext db)
        {
            _db = db;
        }

        [Route("api/book")]
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new {data = _db.Books.ToList()});
        }
    }
}