using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonLibraryMona.Models
{
    internal class BorowerCard
    {
        [Key, ForeignKey("Borower")]
        public int BorowerCardID { get; set; }

        public int BorowerID { get; set; }
        public string LibraryCardNummber { get; set; }

        public string LibraryCardPin { get; set; }

       
       
        public Borower borower { get; set; }

        public ICollection<Book> Books { get; set; }=new List <Book>(); 

    }
}
