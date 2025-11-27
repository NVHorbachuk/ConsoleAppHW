//using System;

//class ArrayMinFinder
//{
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;

//        Console.WriteLine("Пошук Мінімального Числа у Масиві");
//        // Ствторюємо масив
//        int[] numbers = { 31, 5, 12, 3, 9, 1, 15,10,66, 11, 6, 2 };

//        Console.Write("Початковий масив: [");
//        Console.Write(string.Join(", ", numbers));
//        Console.WriteLine("]");

//        int minNumber = numbers[0];

   
//        foreach (int number in numbers)
//        {
//            // Тут є умова порівняння 
           
//            if (number < minNumber)
//            {
//                minNumber = number; // Мінімальне значення
//            }
//        }

//        // 4. Виводимо результат
 
//        Console.WriteLine($"Мінімальне число у масиві: {minNumber}");

//        Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
//        Console.ReadKey();
//    }
//}