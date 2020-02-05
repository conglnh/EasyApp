using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EasyAqq.WebApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EasyAqq.WebApp.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Book Book { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid) return Page();
            await _db.Books.AddAsync(Book);
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
        }
    }
}