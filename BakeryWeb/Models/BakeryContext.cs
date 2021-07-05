
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BakeryWeb.Models
{
    public class BakeryContext:DbContext
    {
        public BakeryContext(DbContextOptions<BakeryContext> options) : base(options)
        {

        }
        public DbSet<Bakery> Bakerys { get; set; }
    }
}
