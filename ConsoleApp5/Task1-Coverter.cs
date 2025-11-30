//// Task 1
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

//        // Основний цикл do/while
//        do
//        {
//            Console.WriteLine(" Конвертер Температур (°C <=> °F)");


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

//            //            Логіка визначення, яку конвертацію виконувати
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

//            Console.WriteLine($ Результат: { temperature: N2}
//            { inputUnit} = { result: N2}
//            { resultUnit}
//            ");


//            Console.Write("Бажаєте виконати ще одну конвертацію? (Y/N): ");
//            string choice = Console.ReadLine().ToUpper();
//            continueConverting = (choice == "Y");

//        } while (continueConverting);

//        Console.WriteLine("Дякуємо за використання конвертера!");
//        Console.ReadKey();
//    }
//}