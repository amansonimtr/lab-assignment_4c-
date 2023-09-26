using System;
using System.Collections.Generic;

class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
}

class Bookshelf
{
    private Dictionary<string, Book> booksByTitle = new Dictionary<string, Book>();


    public Book this[string title]
    {
        get
        {
            if (booksByTitle.ContainsKey(title))
            {
                return booksByTitle[title];
            }
            else
            {
                throw new KeyNotFoundException($"Book with title '{title}' not found on the bookshelf.");
            }
        }
        set
        {
            booksByTitle[title] = value;
        }
    }

    public void AddBook(Book book)
    {
        if (!booksByTitle.ContainsKey(book.Title))
        {
            booksByTitle[book.Title] = book;
        }
        else
        {
            Console.WriteLine($"A book with title '{book.Title}' already exists on the bookshelf.");
        }
    }

    public void RemoveBook(string title)
    {
        if (booksByTitle.ContainsKey(title))
        {
            booksByTitle.Remove(title);
        }
        else
        {
            Console.WriteLine($"Book with title '{title}' not found on the bookshelf.");
        }
    }
}

class Program
{
    static void Main()
    {
        Bookshelf shelf = new Bookshelf();

        Book book1 = new Book { Title = "Book Title 1", Author = "Author 1" };
        Book book2 = new Book { Title = "Book Title 2", Author = "Author 2" };

        shelf.AddBook(book1);
        shelf.AddBook(book2);

       
        Console.WriteLine("Book 1: " + shelf["Book Title 1"].Author);
        Console.WriteLine("Book 2: " + shelf["Book Title 2"].Author);

        
        try
        {
            Console.WriteLine(shelf["Non-Existent Book"]);
        }
        catch (KeyNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadLine();
    }
}
