using ListBook.Model;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace ListBook.Controllers
{

    [Route("api/book")]
    [ApiController]
    public class BookController : Controller
    {
       private ApplicationDbContext _context;
        public BookController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new  {data = _context.Books.ToList()});
        }


        [HttpDelete]
        public async Task<IActionResult> Delete(int Id)
        {
            var book = await _context.Books.FindAsync(Id);
            if (book==null)
            {
                return Json(new { success = false, message = "Error Deleting" });
            }

            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return Json(new { success = true, message = "Success Deleting" });
        }


    }
}
