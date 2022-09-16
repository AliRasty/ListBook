using ListBook.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ListBook.Pages.ListBooks
{
    public class EditBookModel : PageModel
    {

        private ApplicationDbContext _context;

        public EditBookModel(ApplicationDbContext context)
        {
            _context = context;
            
        }

        [BindProperty]
        public Book book { get; set; }
        public void OnGet(int id)
        {
            book = _context.Books.Find(id);     
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                _context.Update(book);
                _context.SaveChanges();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}
