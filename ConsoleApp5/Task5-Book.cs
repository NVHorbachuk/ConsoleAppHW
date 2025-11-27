//// Task 5

//using System;


//class Book
//{

//    public string Title { get; set; }
//    public string Author { get; set; }
//    public int Year { get; set; }

//    public Book(string title, string author, int year)
//    {
//        Title = title;
//        Author = author;
//        Year = year;
//    }


//    public void DisplayInfo()
//    {
//        Console.WriteLine($"Назва:    {Title}");
//        Console.WriteLine($"Автор:    {Author}");
//        Console.WriteLine($"Рік видання: {Year}");
//    }
//}

//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;

//        Console.WriteLine(" 'Книга' (Book)");


//        Book book1 = new Book("Залишенець. Чорний ворон", "Василь Шкляр", 2009);
//        Book book2 = new Book("1984", "Джордж Орвелл", 1949);
//        Book book3 = new Book("Думай і багатій", "Наполеон Гілл", 1937);

//        Console.WriteLine("\n--- Виведення інформації про об'єкти ---\n");
//        Console.WriteLine("Книга 1:");
//        book1.DisplayInfo();
//        Console.WriteLine("\nКнига 2:");
//        book2.DisplayInfo();
//        Console.WriteLine("\nКнига 3:");
//        book3.DisplayInfo();


//        Console.WriteLine($"\nПрямий доступ до поля: {book1.Title} була написана у {book1.Year} році.");

//        Console.WriteLine("\n=");
//        Console.WriteLine("Натисніть будь-яку клавішу для виходу...");

//        Console.ReadKey();
//    }
//}
