

using October30Practice.Models;

Book b1 = new Book("Algorithms And Datastructures",270,3,"MIT Press",560);
Book b2 = new Book("Mosa Lina", 34, 1, "N/A", 40);

Library lib = new Library();

lib.AddBook(b1);
lib.AddBook(b2);
Console.WriteLine();
Console.WriteLine(b1.ShowInfo());
Console.WriteLine(b2.ShowInfo());
Console.WriteLine();

Console.WriteLine( lib.GetBookById(1).IsFound ? lib.GetBookById(1).book.ShowInfo() : "Specified book does not exist!" );
Console.WriteLine( lib.GetBookById(2).IsFound ? lib.GetBookById(2).book.ShowInfo() : "Specified book does not exist!" );

b1.Sell();
b1.Sell();

Console.WriteLine();
Console.WriteLine(b1.ShowInfo());
Console.WriteLine();

b2.Sell();
b2.Sell();
b2.Sell();
b2.Sell();

Console.WriteLine();
Console.WriteLine(b2.ShowInfo());
Console.WriteLine();

