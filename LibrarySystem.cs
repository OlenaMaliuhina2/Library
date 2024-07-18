using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary;

namespace LibraryApp
{
    public class LibrarySystem
    {
        private List<Book> bookList = new List<Book>();

        public void AddBook ()
        {
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter book author: ");
            string author = Console.ReadLine();

            Console.Write("Enter book release date (yyyy-mm-dd): ");
            DateTime releaseDate;
            DateTime.TryParse(Console.ReadLine(), out releaseDate);

            Book newBook = new Book (title, author, releaseDate);
            bookList.Add (newBook);
            Console.WriteLine("The Book was added successfully!");
        }
        public void RemoveBook () 
        {
            Console.Write("Enter the title of the book to remove: ");
            string title = Console.ReadLine();

            Book bookToRemove = bookList.FirstOrDefault(book => book.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
            if (bookToRemove != null)
            {
                
                bookList.Remove(bookToRemove);
                Console.WriteLine("Book removed successfully!");
            }
            else
            {
                //Console.WriteLine("Book not found.");
                throw new BookNotFoundException("Book not found.");
            }
        }

        public void ListBooks()
        { 
            if (bookList.Count > 0)
            {
                Console.WriteLine("\nBooks in the library:");
                foreach (Book book in bookList)
                {
                    Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, Release Date: {book.ReleaseDate.ToShortDateString()}");
                }
             }
            else 
            {
                Console.WriteLine("No books in the library.");
            }
         }

    }
}