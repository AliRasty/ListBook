using ListBook.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ListBook.Pages.ListBooks
{
    public class CreateBookModel : PageModel
    {
        private ApplicationDbContext _context;
        public CreateBookModel(ApplicationDbContext context)
        {
            _context = context;
        }
        [BindProperty]
        public Book Book { get; set; }
        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            _context.Books.Add(Book);
            _context.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
