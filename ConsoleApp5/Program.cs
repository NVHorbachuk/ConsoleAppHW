// // Task 1
//using System;

//class Program
//{

//    static double CelsiusToFahrenheit(double celsius)
//    {

//        return (celsius * 9 / 5) + 32;
//    }


//    static double FahrenheitToCelsius(double fahrenheit)
//    {
//        return (fahrenheit - 32) * 5 / 9;
//    }

//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        bool continueConverting = true;


//        do
//        {
//            Console.WriteLine("------------------------------------------");
//            Console.WriteLine(" Конвертер Температур (°C <=> °F)");
//            Console.WriteLine("------------------------------------------");

//            double temperature = 0;
//            string inputUnit = "";


//            while (true)
//            {
//                Console.Write("Введіть числове значення температури: ");
//                string input = Console.ReadLine();

//                if (double.TryParse(input, out temperature))
//                {
//                    break;
//                }
//                Console.WriteLine("Помилка: Введіть коректне число.");
//            }


//            while (inputUnit != "C" && inputUnit != "F")
//            {
//                Console.Write("Оберіть одиницю виміру (C для Цельсія, F для Фаренгейта): ");
//                inputUnit = Console.ReadLine().ToUpper();

//                if (inputUnit != "C" && inputUnit != "F")
//                {
//                    Console.WriteLine("Помилка: Оберіть 'C' або 'F'.");
//                }
//            }

//            double result = 0;
//            string resultUnit = "";


//            if (inputUnit == "C")
//            {
//                result = CelsiusToFahrenheit(temperature);
//                resultUnit = "°F (Фаренгейт)";
//            }
//            else if (inputUnit == "F")
//            {
//                result = FahrenheitToCelsius(temperature);
//                resultUnit = "°C (Цельсій)";
//            }


//            Console.WriteLine("------------------------------------------");
//            Console.WriteLine($"✅ Результат: {temperature:N2} {inputUnit} = {result:N2} {resultUnit}");
//            Console.WriteLine("------------------------------------------");


//            Console.Write("Бажаєте виконати ще одну конвертацію? (Y/N): ");
//            string choice = Console.ReadLine().ToUpper();
//            continueConverting = (choice == "Y");

//        } while (continueConverting);

//        Console.WriteLine("Дякуємо за використання конвертера!");
//        Console.ReadKey();
//    }
//}

// // Task 2

//using System;
//class AgeChecker
//{
//    static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        bool continueLoop = false;


//        do
//        {
//            int age = 0;
//            Console.Write("Please write your age: ");
//            string input = Console.ReadLine();
//            continueLoop = false;

//            if (int.TryParse(input, out age))
//            {

//                if (age < 0)
//                {
//                    Console.WriteLine("Something wrong. Your number cannot be negative.");
//                    Console.WriteLine("If you want to try again, write Y.");
//                    Console.Write("Do you want to try again? (Y/N): ");
//                    string choice = Console.ReadLine().ToUpper();
//                    continueLoop = (choice == "Y");
//                }

//                else
//                {
//                    if (age is >= 0 and < 12)
//                    {
//                        Console.WriteLine("You're Child");
//                    }
//                    else if (age is >= 12 and < 18)
//                    {
//                        Console.WriteLine("You're teenager");
//                    }
//                    else
//                    {
//                        Console.WriteLine("You're adult");
//                    }

//                    Console.WriteLine("Goodbye!");
//                }
//            }
//            else // Якщо це не число
//            {
//                Console.WriteLine("Something wrong. Please write a current number.");
//                Console.WriteLine("If you want to try again, write Y.");
//                Console.Write("Do you want to try again? (Y/N): ");
//                string choice = Console.ReadLine().ToUpper();
//                continueLoop = (choice == "Y");
//            }

//        } while (continueLoop);
//    }
//}


// // Task 3

//using System;

//class MultiplicationTable
//{

//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;


//        Console.WriteLine("'Таблиця множення'");



//        int number = GetValidIntegerFromUser();


//        PrintTable(number);


//        Console.WriteLine("Натисніть будь-яку клавішу для виходу");

//        Console.ReadKey();
//    }


//    private static int GetValidIntegerFromUser()
//    {

//        int number;

//        Console.Write("Будь ласка, введіть Ваше ціле число: ");


//        do
//        {

//            string input = Console.ReadLine() ?? string.Empty;

//            if (int.TryParse(input, out number))
//            {

//                return number;
//            }
//            else
//            {
//                Console.WriteLine("Помилка: Дане значення не є цілим числом. Спробуйте ще раз.");
//                Console.Write("Будь ласка, введіть ціле число: ");
//            }
//        }

//        while (true);
//    }


//    /// <param name="number">.</param>
//    private static void PrintTable(int number)
//    {
//        Console.WriteLine($"\n Таблиця множення для {number} ---\n");


//        for (int i = 1; i <= 10000; i++)
//        {
//            int result = number * i;


//            Console.WriteLine($"{number,4} × {i,2} = {result,5}");
//        }
//    }
//}

//// Task 4
//using System;

//class RangeCalculator
//{

//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;


//        Console.WriteLine(" 'Сума чисел у діапазоні'");



//        Console.WriteLine("Введіть початок діапазону:");
//        int start = GetValidIntegerFromUser();


//        Console.WriteLine("\nВведіть кінець діапазону:");
//        int end = GetValidIntegerFromUser();


//        long sum = SumRange(start, end);


//        int min = Math.Min(start, end);
//        int max = Math.Max(start, end);


//        Console.WriteLine($"Сума всіх чисел від {min} до {max} (включно) становить: {sum}");


//        Console.WriteLine("Натисніть будь-яку клавішу для виходу...");

//        Console.ReadKey();
//    }


//    private static int GetValidIntegerFromUser()
//    {
//        int number;

//        Console.Write("Введіть ціле число: ");


//        do
//        {

//            string input = Console.ReadLine() ?? string.Empty;

//            if (int.TryParse(input, out number))
//            {

//                return number;
//            }
//            else
//            {
//                Console.WriteLine("Введене значення не є цілим числом. Спробуйте ще раз.");
//                Console.Write("Введіть ціле число: ");
//            }
//        }
//        while (true);
//    }


//    /// <param name="start">Початок діапазону.</param>
//    /// <param name="end">Кінець діапазону.</param>

//    private static long SumRange(int start, int end)
//    {
//        int min = Math.Min(start, end);
//        int max = Math.Max(start, end);
//        long sum = 0;

//        for (int i = min; i <= max; i++)
//        {
//            sum += i;
//        }

//        return sum;


//    }
//}


// Task 5

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
