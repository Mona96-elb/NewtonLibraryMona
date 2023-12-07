using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonLibraryMona.Models
{
    internal class Borower
    {

        public int BorowerID { get; set;}
        public string FirstName { get; set; } 
        public string LastName { get; set; }

      
        public BorowerCard BorowerCard { get; set; }
        public ICollection<BookLoan> BookLoans { get; set; } = new List<BookLoan>();

       

    }
}
