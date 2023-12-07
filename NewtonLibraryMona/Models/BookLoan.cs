using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewtonLibraryMona.Models
{
    internal class BookLoan
    {
        
        public int Id { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime? ReturnDate { get; set; }




        public int BorowerID { get; set; }
        public int BookID { get; set; }

      
        public Borower Borower { get; set; }
        public Book Book { get; set; }


    }
}

