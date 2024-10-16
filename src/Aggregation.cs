using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; set; }

    public Book(string title)
    {
        Title = title;
    }
}

public class Library
{
    private List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
        books.Add(book);
        Console.WriteLine($"Added '{book.Title}' to the library.");
    }

    public void ListBooks()
    {
        Console.WriteLine("Books in the library:");
        foreach (var book in books)
        {
            Console.WriteLine(book.Title);
        }
    }
}

class Program
{
    static void Main()
    {
        Library library = new Library();
        Book book1 = new Book("1984");
        Book book2 = new Book("Brave New World");

        library.AddBook(book1); // Added '1984' to the library.
        library.AddBook(book2); // Added 'Brave New World' to the library.

        library.ListBooks();
        // Books in the library:
        // 1984
        // Brave New World
    }
}
