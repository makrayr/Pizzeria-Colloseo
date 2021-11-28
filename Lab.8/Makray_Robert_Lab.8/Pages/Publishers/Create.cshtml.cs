using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Makray_Robert_Lab._8.Data;
using Makray_Robert_Lab._8.Models;

namespace Makray_Robert_Lab._8.Pages.Publishers
{
    public class CreateModel : PageModel
    {
        private readonly Makray_Robert_Lab._8.Data.Makray_Robert_Lab_8Context _context;

        public CreateModel(Makray_Robert_Lab._8.Data.Makray_Robert_Lab_8Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Publisher Publisher { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Publisher.Add(Publisher);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
