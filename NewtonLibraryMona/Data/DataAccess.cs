using NewtonLibraryMona.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Helpers;



namespace NewtonLibraryMona.Data
{
    internal class DataAccess
    {

        
        public void seed()
        {
            Context context = new Context();

            var author1 = new Author { FirstName = "John", LastName = "Doe" };
            var author2 = new Author { FirstName = "Jane", LastName = "Smith" };
            var author3 = new Author { FirstName = "Nina", LastName = "Björn" };
            context.Authors.AddRange(author1, author2, author3);

            var book1 = new Book { Title = "Dancing queen", IsBn = "64789846", PublishYear = 2020, Grade = 4.9 };
            var book2 = new Book { Title = "Död man walking", IsBn = "675356898", PublishYear = 2021, Grade = 4.3 };
            var book3 = new Book { Title = "Malibu Rising", IsBn = "554379804", PublishYear = 2022, Grade = 3.9 };
            context.Books.AddRange(book1, book2, book3);

            var borower1 = new Borower { FirstName = "Anna", LastName = "Johansson" };
            var borower2 = new Borower { FirstName = "Tina", LastName = "Axelsson " };
            var borower3 = new Borower { FirstName = "Sara", LastName = "Åström" };
            context.Borowers.AddRange(borower1, borower2, borower3);


            var BorowerCard1 = new BorowerCard { LibraryCardNummber = "2232212", LibraryCardPin="3456" };
            var BorowerCard2 = new BorowerCard { LibraryCardNummber = "4353454", LibraryCardPin = "5454" };
            var BorowerCard3 = new BorowerCard { LibraryCardNummber = "5455426", LibraryCardPin = "4354" };

            book1.Authors.Add(author1 );
            book2.Authors.Add(author2);
            book3.Authors.Add(author3);


            borower1.BorowerCard = BorowerCard1;
            borower2.BorowerCard = BorowerCard2;
            borower3.BorowerCard = BorowerCard3;




            var bookLoan1 = new BookLoan { Borower = borower1, Book = book1, LoanDate = DateTime.Now };
            context.BookLoans.Add(bookLoan1);

            var bookLoan2 = new BookLoan { Borower = borower2, Book = book2, LoanDate = DateTime.Now };
            context.BookLoans.Add(bookLoan2);

            var bookLoan3 = new BookLoan { Borower = borower3, Book = book3, LoanDate = DateTime.Now };
            context.BookLoans.Add(bookLoan3);



            context.SaveChanges();

            
        }


       

        Context context= new Context();




        public void CreateAuthor()
        {
            string firstName = "";
            string lastName = "";
            Console.WriteLine("Entier firstName");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            lastName = Console.ReadLine();

            var author = new Author { FirstName = firstName, LastName = lastName };
            context.Authors.Add(author);
            context.SaveChanges();
            
            

            
            
        }

        public Book CreateBook(string Title, string Isbn)
        {
            Random random = new Random();


            var book = new Book { Title = Title, IsBn = Isbn, PublishYear = random.Next(2020, 2025), Grade = random.Next(0, 5) };
            context.Books.Add(book);
            context.SaveChanges();
            return book;


        }    
            


        

        public void CreateBorower()
        {
            Random rnd = new Random();

            string str = rnd.Next(10000, 99999).ToString();
            string str1 = rnd.Next(1000, 9999).ToString();

            var borowerCard = new BorowerCard { LibraryCardNummber= str, LibraryCardPin = str1};

            
            Console.WriteLine("Entier firstName");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Last Name");
            string lastName = Console.ReadLine();

            var borower = new Borower { FirstName = firstName, LastName = lastName, BorowerCard = borowerCard };
            context.Borowers.Add(borower);
            context.SaveChanges();
           
        }

        public void BorrowBook(Borower borower, Book book)
        {
            var bookL= context.Books.ToList();
            for (int i = 0; i < bookL.Count; i++)
            {
                if (bookL[i].IsAvailable == true)
                    Console.WriteLine($"{bookL[i].BookID}: {bookL[i].Title}");



            }
            var loan = new BookLoan { Borower = borower, Book = book, LoanDate = DateTime.Now };
            context.BookLoans.Add(loan);
            context.SaveChanges();
        }


            

            
          



        public void ReturnBook(int borower, int book)
        {
            var loan = context.BookLoans.SingleOrDefault(l => l.BorowerID == borower && l.BookID == book && l.ReturnDate == null);

            if (loan != null)
            {
                loan.ReturnDate = DateTime.Now;
                context.SaveChanges();
            }
            else
            {
                Console.WriteLine("Error: The loan for the book was not found or has already been returned.");
            }
        }

        public void DeleteBorrower(int borowerID)
        {
            var borower = context.Borowers.SingleOrDefault(l => l.BorowerID == borowerID);
            if (borower != null)
            {
                context.Borowers.Remove(borower);
                context.SaveChanges();

            }
            else
            {
                return;
            }
           
        }

        public void DeleteBook(int bookID)
        {
            var books = context.Books.SingleOrDefault(l => l.BookID == bookID);
            if (books != null)
            {
                context.Books.Remove(books);
                context.SaveChanges();
            }
            else
            {
                return;
            }
           
        }

        public void DeleteAuthor(int AuthorID)
        {
            var Author = context.Authors.SingleOrDefault(l => l.AuthorID == AuthorID);
            if (Author != null)
            {
                context.Authors.Remove(Author);
                context.SaveChanges();

            }
            else
            {
                return;
            }
           
        }


    }


}











    
