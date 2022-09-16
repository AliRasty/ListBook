using ListBook.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ListBook.Pages.ListBooks
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext _context;
        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Book> books { get; set; }
        public void OnGet()
        {
            books = _context.Books.ToList();
        }
    }
}
