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
