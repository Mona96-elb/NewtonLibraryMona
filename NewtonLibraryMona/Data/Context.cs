using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewtonLibraryMona.Models;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace NewtonLibraryMona.Data
{
    internal class Context: DbContext
    {

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Borower> Borowers { get; set; }
        public DbSet<BookLoan> BookLoans { get; set; }


       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"
                    Server=localhost; 
                    Database=NewtonLibraryMona;
                    Trusted_Connection=True; 
                    Trust Server Certificate=Yes; 
                    User Id=NewtonLibrary; 
                    password=NewtonLibrary");
        }
    }
}





   

