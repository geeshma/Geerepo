using System;
using HandsonentityFramworkdoing.Entities;
using System.Linq;
using System.Collections.Generic;

namespace HandsonentityFramworkdoing
{
    class Program
    {
        //get all books from bookmaster
        public static void GetAllBooks()
        {
            TrainingContext db = new TrainingContext();
            List<BookMaster> list = db.BookMasters.ToList();
            foreach (var item in list)
            {
                Console.WriteLine($"BookName:{item.BookName}" +
                                  $"BookCode:{ item.BookCode}"+
                                  $"pub_year:{item.PubYear}"+
                                  $"Author:{item.Author}"+
                                  $"Book_Category:{item.BookCategory}"
                    );
            }
        }
        public static void GetBookById(decimal BookCode)
        {
            TrainingContext db = new TrainingContext();
            BookMaster book = db.BookMasters.SingleOrDefault(b=>b.BookCode==BookCode);
            if (book != null)
            {
                Console.WriteLine($"BookName:{book.BookName}" +
                                   $"pub_year:{book.PubYear}" +
                                  $"Author:{book.Author}" +
                                  $"Book_Category:{book.BookCategory}"
                     );
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }
        }
        public static void GetBookbyAuthor(string Author)
        {
            TrainingContext db = new TrainingContext();
            List<BookMaster> list = db.BookMasters.Where(b => b.Author == Author).ToList();
            foreach(var item in list)
            {
                Console.WriteLine($"BookName:{item.BookName}" +
                                   $"pub_year:{item.PubYear}" +
                                    $"BookCode:{ item.BookCode}" +
                                    $"Book_Category:{item.BookCategory}"
                                    );
            }    
        
        }
        public static void AddBook(BookMaster book)
        {
            TrainingContext db = new TrainingContext();
            
                db.BookMasters.Add(book); //adds record to bookmaster table
                
            
        }
        public static void UpdateBook(BookMaster book)
        {
            using (TrainingContext db = new TrainingContext())
            {
                db.BookMasters.Update(book); //adds record to bookmaster table
                db.SaveChanges();
            }
        }
        public static void DeleteBook(decimal bookCode)
        {
            using (TrainingContext db = new TrainingContext())
            {
                BookMaster book = db.BookMasters.Find(bookCode);
                db.BookMasters.Remove(book); //adds record to bookmaster table
                db.SaveChanges();
            }
        }
        static void Main(string[] args)
        {
          /*GetAllBooks();*/
            /* Console.WriteLine("Enter book code for displaying book");
             decimal BookCode = decimal.Parse(Console.ReadLine());
             GetBookById(BookCode);*/
           /* Console.WriteLine("Enter author");
            string Author = Console.ReadLine();
            GetBookbyAuthor(Author);*/
            BookMaster book = new BookMaster()
            {
                BookName = "Triangle",
                BookCode = 10000066,
                BookCategory = "Simple",
                Author = "Joseph",
                PubYear = 2021
            };
            AddBook(book);
            GetAllBooks();

        }
        }
    }

