using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Makray_Robert_Lab._8.Data;
using Makray_Robert_Lab._8.Models;

namespace Makray_Robert_Lab._8.Pages.Publishers
{
    public class IndexModel : PageModel
    {
        private readonly Makray_Robert_Lab._8.Data.Makray_Robert_Lab_8Context _context;

        public IndexModel(Makray_Robert_Lab._8.Data.Makray_Robert_Lab_8Context context)
        {
            _context = context;
        }

        public IList<Publisher> Publisher { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.Include(b => b.Publisher).ToListAsync();
            Publisher = await _context.Publisher.ToListAsync();
        }
    }
}
