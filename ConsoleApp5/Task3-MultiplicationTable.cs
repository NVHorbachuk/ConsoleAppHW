
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