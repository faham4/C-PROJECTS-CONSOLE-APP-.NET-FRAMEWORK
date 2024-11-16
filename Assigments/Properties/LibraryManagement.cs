using LibraryManagement;
using System.Collections.Generic;
using System;

ario 1: Library Management System
csharp
Copy code
using System;
using System.Collections.Generic;

namespace LibraryManagement
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
        public bool IsAvailable { get; set; } = true;
    }

    class Library
    {
        private List<Book> book = new List<Book>();

        public void AddBook(Book book) => book.Add(book);

        public void RemoveBook(string isbn) =>
            book.RemoveAll(b => b.ISBN == isbn);

        public bool IsBookAvailable(string isbn) =>
            book.Exists(b => b.ISBN == isbn && b.IsAvailable);
    }

    class Member
    {
        public string Name { get; set; }

        public void BorrowBook(Library library, string isbn)
        {
            if (library.IsBookAvailable(isbn))
            {
                var book = library.Book.Find(b => b.ISBN == isbn);
                book.IsAvailable = false;
                Console.WriteLine($"{Name} borrowed \"{book.Title}\".");
            }
            else
                Console.WriteLine($"The book with ISBN {isbn} is not available.");
        }

        public void ReturnBook(Library library, string isbn)
        {
            var book = library.Book.Find(b => b.ISBN == isbn);
            if (book != null && !book.IsAvailable)
            {
                book.IsAvailable = true;
                Console.WriteLine($"{Name} returned \"{book.Title}\".");
            }
        }
    }