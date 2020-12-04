using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Muresan_Andreea_Lab8.Models;

namespace Muresan_Andreea_Lab8.Data
{
    public class Muresan_Andreea_Lab8Context : DbContext
    {
        public Muresan_Andreea_Lab8Context (DbContextOptions<Muresan_Andreea_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Muresan_Andreea_Lab8.Models.Book> Book { get; set; }

        public DbSet<Muresan_Andreea_Lab8.Models.Publisher> Publisher { get; set; }
        public object Category { get; internal set; }
    }
}
