using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpTraining_jan2725
{
    class Book
    {
        // Define properties
        // Complete Step 1:............
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

        // Define constructor
        // Complete Step 2:............
        public Book()
        {

        }
        public Book(string title, string author, string isbn)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
    }

    class Library
    {
        // Define collection to store books
        // Complete Step 3:............
        List<Book> books = new List<Book>();

        // Add method to add a book
        // Complete Step 4:............
        public void addBook(string title, string author, string isbn)
        {
            books.Add(new Book(title, author, isbn));
            Console.WriteLine("Book added successfully");
        }


        // Add method to remove a book by ISBN
        // Complete Step 5:............
        public void removeBook(string isbn)
        {
            int initialCount = books.Count;
            books.RemoveAll(book => book.ISBN == isbn);

            if (books.Count < initialCount)
            {
                Console.WriteLine("Book Removed Sucessfully");
            }
            else
            {
                Console.WriteLine("Book not found");
            }
        }


        // Add method to list all books
        // Complete Step 6:............
        public void displayBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books in the libarary.");
                return;
            }
            Console.WriteLine("Listing all books:");
            foreach (var book in books)
            {
                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Remove Book");
                Console.WriteLine("3. List Books");
                Console.WriteLine("4. Exit");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // Prompt for book details and add book
                        // Complete Step 7:............
                        string title = Console.ReadLine();
                        string author = Console.ReadLine();
                        string isbn = Console.ReadLine();
                        library.addBook(title, author, isbn);
                        break;
                    case 2:
                        // Prompt for ISBN and remove book
                        // Complete Step 8:............
                        string isbn1 = Console.ReadLine();
                        library.removeBook(isbn1);
                        break;
                    case 3:
                        // List all books
                        // Complete Step 9:............
                        library.displayBooks();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
