using Microsoft.EntityFrameworkCore;
using ReadMore_Books.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadMore_Books.Context
{
    public class AppDbContext :DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = . ; Database = ReadMore_Books ; Trusted_Connection = True ; TrustServerCertificate = True");
        }
    }
}
