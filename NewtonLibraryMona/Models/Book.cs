using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonLibraryMona.Models
{
    internal class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public string IsBn { get; set; } 

        public int PublishYear { get; set; }

        public double? Grade { get; set; }

        public bool? IsAvailable { get; set; } 


        public ICollection<Author> Authors { get; set; } = new List<Author>();
        public BookLoan BookLoan { get; set; }



       

        





    }

        
}   