using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyAqq.WebApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EasyAqq.WebApp.Pages.BookList
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public EditModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set; }

        public async Task OnGet(int id)
        {
            Book = await _db.Books.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();

            var bookFromDb = await _db.Books.FindAsync(Book.Id);
            bookFromDb.Name = Book.Name;
            bookFromDb.Author = Book.Author;
            bookFromDb.ISBN = Book.ISBN;
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}