using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Makray_Robert_Lab._8.Data;
using Makray_Robert_Lab._8.Models;

namespace Makray_Robert_Lab._8.Pages.Books
{
    public class DetailsModel : PageModel
    {
        private readonly Makray_Robert_Lab._8.Data.Makray_Robert_Lab_8Context _context;

        public DetailsModel(Makray_Robert_Lab._8.Data.Makray_Robert_Lab_8Context context)
        {
            _context = context;
        }

        public Book Book { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Book = await _context.Book.FirstOrDefaultAsync(m => m.ID == id);

            if (Book == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
