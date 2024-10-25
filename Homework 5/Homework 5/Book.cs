using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5
{
    internal class Book
    {
        // წიგნის დეტალები
        private string title;
        private string author;
        private string isbn;
        private int copiesAvailable;

        // კონსტრუქტორი, რომელიც ინიციალიზაციას უკეთებს ახალ წიგნს სათაურით, ავტორით, ISBN-ით და არსებული ასლებით
        public Book(string title, string author, string isbn, int copiesAvailable)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            CopiesAvailable = copiesAvailable;
        }

        // სათაურის property ვალიდაციით ცარიელი ან null სტრინგებისთვის
        public string Title
        {
            get { return title; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Title cannot be empty.");
                title = value;
            }
        }

        // ავტორის property ვალიდაციით ცარიელი ან null სტრინგებისთვის
        public string Author
        {
            get { return author; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Author cannot be empty.");
                author = value;
            }
        }

        // ISBN-ის property 13 სიმბოლოს ვალიდაციით (კითხვის და დაწერის უფლება)
        public string ISBN
        {
            get { return isbn; }
            set
            {
                if (value.Length != 13)
                    throw new ArgumentException("ISBN must be 13 characters long.");
                isbn = value;
            }
        }

        // CopiesAvailable property უზრუნველყოფს, რომ ასლების რაოდენობა უარყოფითი არ იყოს
        public int CopiesAvailable
        {
            get { return copiesAvailable; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Copies available cannot be negative.");
                copiesAvailable = value;
            }
        }

        // მეთოდი წიგნის დეტალების გამოსატანად
        public void DisplayInfo()
        {
            Console.WriteLine($"Title: {title}, Author: {author}, ISBN: {isbn}, Copies Available: {copiesAvailable}");
        }

        // მეთოდი წიგნის გასანათხოვრებლად (ამცირებს ხელმისაწვდომ ასლებს)
        public bool BorrowBook()
        {
            if (copiesAvailable > 0)
            {
                copiesAvailable--;
                Console.WriteLine("Book borrowed successfully.");
                return true;
            }
            Console.WriteLine("Sorry, no copies available.");
            return false;
        }

        // მეთოდი წიგნის დაბრუნებისთვის (ზრდის ხელმისაწვდომ ასლებს)
        public void ReturnBook()
        {
            copiesAvailable++;
            Console.WriteLine("Book returned successfully.");
        }
    }
}
