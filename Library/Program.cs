using System.Runtime.CompilerServices;

class Book
{
    string Title;
    string Author;
    string ISBN;
    int NoOfpages;

    void DisplayInfo()
    {
        //Output the book information to the console
        Console.WriteLine("book information");
        Console.WriteLine("------------------");
        Console.WriteLine($"Book title: {Title}");
        Console.WriteLine($"Book author: {Author}");
        Console.WriteLine($"Book ISBN: {ISBN}");
        Console.WriteLine($"Book NoOfpages: {NoOfpages}");
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        //create a new instance of the book class
        Book book = new Book();
        book.Title = "C# for beginners";
        book.Author = "Bill Gates";
        book.ISBN = "123456677";
        book.NoOfpages = 200;

        Book book2 = new Book();
        book2.Title = "c# methods and classes";
        book2.Author = "Micrsoft";
        book2.ISBN = "625618126";
        book2.NoOfpages = 50;

        //output book information to the console
        book.DisplayInfo();
        book2.DisplayInfo();

    }
}
