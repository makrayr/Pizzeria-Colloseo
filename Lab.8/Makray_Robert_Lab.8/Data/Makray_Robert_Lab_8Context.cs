using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Makray_Robert_Lab._8.Models;

namespace Makray_Robert_Lab._8.Data
{
    public class Makray_Robert_Lab_8Context : DbContext
    {
        public Makray_Robert_Lab_8Context (DbContextOptions<Makray_Robert_Lab_8Context> options)
            : base(options)
        {
        }

        public DbSet<Makray_Robert_Lab._8.Models.Book> Book { get; set; }

        public DbSet<Makray_Robert_Lab._8.Models.Publisher> Publisher { get; set; }
    }
}
