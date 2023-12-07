using Microsoft.EntityFrameworkCore;
using NewtonLibraryMona.Data;
using NewtonLibraryMona.Models;

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

            
            dataAccess.seed();
          












        }

    }

    
}