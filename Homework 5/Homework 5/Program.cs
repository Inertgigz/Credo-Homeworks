namespace Homework_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("\nLibrary Menu:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. Display All Books");
                Console.WriteLine("4. Borrow Book");
                Console.WriteLine("5. Return Book");
                Console.WriteLine("6. Search Book by Title");
                Console.WriteLine("7. Search Book by ISBN");
                Console.WriteLine("8. Exit");
                Console.Write("Select an option: ");
                int option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.Write("Enter title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter author: ");
                        string author = Console.ReadLine();
                        Console.Write("Enter ISBN: ");
                        string isbn = Console.ReadLine();
                        Console.Write("Enter copies available: ");
                        int copiesAvailable = int.Parse(Console.ReadLine());

                        try
                        {
                            Book newBook = new Book(title, author, isbn, copiesAvailable);
                            library.AddBook(newBook);
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;

                    case 2:
                        Console.Write("Enter ISBN of the book to remove: ");
                        string isbnToRemove = Console.ReadLine();
                        library.RemoveBook(isbnToRemove);
                        break;

                    case 3:
                        library.DisplayAllBooks();
                        break;

                    case 4:
                        Console.Write("Enter title of the book to borrow: ");
                        string borrowTitle = Console.ReadLine();
                        Book bookToBorrow = library.SearchByTitle(borrowTitle);
                        if (bookToBorrow != null)
                        {
                            bookToBorrow.BorrowBook();
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;

                    case 5:
                        Console.Write("Enter title of the book to return: ");
                        string returnTitle = Console.ReadLine();
                        Book bookToReturn = library.SearchByTitle(returnTitle);
                        if (bookToReturn != null)
                        {
                            bookToReturn.ReturnBook();
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;

                    case 6:
                        Console.Write("Enter title to search: ");
                        string searchTitle = Console.ReadLine();
                        Book searchedBookByTitle = library.SearchByTitle(searchTitle);
                        if (searchedBookByTitle != null)
                        {
                            searchedBookByTitle.DisplayInfo();
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;

                    case 7:
                        Console.Write("Enter ISBN to search: ");
                        string searchISBN = Console.ReadLine();
                        Book searchedBookByISBN = library.SearchByISBN(searchISBN);
                        if (searchedBookByISBN != null)
                        {
                            searchedBookByISBN.DisplayInfo();
                        }
                        else
                        {
                            Console.WriteLine("Book not found.");
                        }
                        break;

                    case 8:
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }

        }
    }
}
