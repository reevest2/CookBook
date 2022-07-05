using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CookBook.Models;

namespace CookBook.Data
{
    public class CookBookContext : DbContext
    {
        public CookBookContext (DbContextOptions<CookBookContext> options)
            : base(options)
        {
        }

        public DbSet<CookBook.Models.Recipe> Recipe { get; set; }
    }
}
