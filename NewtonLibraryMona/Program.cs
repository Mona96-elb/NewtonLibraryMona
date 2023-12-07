using Microsoft.EntityFrameworkCore;
using NewtonLibraryMona.Data;
using NewtonLibraryMona.Models;
using System.Data;

namespace NewtonLibraryMona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Context context = new Context();

            // Skapa databasen
            DataAccess dataAccess = new DataAccess();


            //  dataAccess.seed();

            // dataAccess.CreateBook("Mona", "hdhshds");


            //  dataAccess.CreateAuthor();

            //dataAccess.ReturnBook(1,1);


            //dataAccess.CreateBorower();

            //dataAccess.DeleteBorrower(1);

            //dataAccess.DeleteAuthor(1);

           // dataAccess.DeleteBook(2);













        }

    }

    
}