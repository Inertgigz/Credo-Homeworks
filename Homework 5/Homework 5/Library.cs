using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Library
    {
        // წიგნების სია ბიბლიოთეკაში ხელმისაწვდომი წიგნების შესანახად
        private List<Book> books = new List<Book>();

        // მეთოდი ბიბლიოთეკაში ახალი წიგნის დასამატებლად
        public void AddBook(Book book)
        {
            books.Add(book);
            Console.WriteLine("Book added to the library.");
        }

        // მეთოდი ბიბლიოთეკიდან წიგნის წასაშლელად ISBN-ის გამოყენებით
        public void RemoveBook(string isbn)
        {
            // წიგნის ძებნა ISBN-ით
            Book bookToRemove = books.Find(b => b.ISBN == isbn);

            if (bookToRemove != null)
            {
                books.Remove(bookToRemove);
                Console.WriteLine("Book removed from the library.");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        // მეთოდი ბიბლიოთეკაში არსებული ყველა წიგნის გამოსაჩენად
        public void DisplayAllBooks()
        {
            Console.WriteLine("Library Inventory:");
            foreach (var book in books)
            {
                book.DisplayInfo();
            }
        }

        // მეთოდი წიგნის სათაურით მოსაძებნად (რეგისტრის იგნორირებით)
        public Book SearchByTitle(string title)
        {
            return books.Find(b => b.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        }

        // მეთოდი წიგნის მოსაძებნად მისი ISBN-ის გამოყენებით
        public Book SearchByISBN(string isbn)
        {
            return books.Find(b => b.ISBN == isbn);
        }
    }
}
