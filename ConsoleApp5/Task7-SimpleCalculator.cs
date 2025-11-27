//using System;

//class SimpleCalculator
//{
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        Console.WriteLine(" Консольний Калькулятор");


//        // Змінні які використовуємо для збереження чисел та результату
//        double num1 = 0;
//        double num2 = 0;
//        double result = 0;
//        string operation = "";
//        bool isValidOperation = false;

//        // Отримуємо перше число з валідацією
//        num1 = GetValidNumber("Введіть перше число: ");

//        // Отримуємо операцію з валідацією
//        while (!isValidOperation)
//        {
//            Console.Write("Оберіть операцію (+, -, *, /): ");
//            operation = Console.ReadLine() ?? "";

//            // Перевіряємо, чи введена коректна операція
//            if (operation == "+" || operation == "-" || operation == "*" || operation == "/")
//            {
//                isValidOperation = true;
//            }
//            else
//            {
//                Console.WriteLine("Помилка: Невідома операція. Спробуйте ще раз.");
//            }
//        }

//        // Отримуємо друге число з валідацією
//        num2 = GetValidNumber("Введіть друге число: ");


//        // Використовуємо switch для виконання обраної операції
//        switch (operation)
//        {
//            case "+":
//                result = num1 + num2;
//                Console.WriteLine($"Результат: {num1} + {num2} = {result}");
//                break;

//            case "-":
//                result = num1 - num2;
//                Console.WriteLine($"Результат: {num1} - {num2} = {result}");
//                break;

//            case "*":
//                result = num1 * num2;
//                Console.WriteLine($"Результат: {num1} * {num2} = {result}");
//                break;

//            case "/":
              
//                if (num2 != 0)
//                {
//                    result = num1 / num2;
//                    Console.WriteLine($"Результат: {num1} / {num2} = {result}");
//                }
//                else
//                {
//                    Console.WriteLine("Помилка: Ділення на нуль неможливе.");
//                }
//                break;

//            default:
//                Console.WriteLine("Виникла непередбачена помилка операції.");
//                break;
//        }

//        Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
//        Console.ReadKey();
//    }

//    /// <param name="prompt">Текст підказки</param>
//    static double GetValidNumber(string prompt)
//    {
//        double number;
//        string input;
//        bool isValid = false;

//        do
//        {
//            Console.Write(prompt);
//            input = Console.ReadLine() ?? "";

//            // Перетворення рядка у число
//            if (double.TryParse(input, out number))
//            {
//                isValid = true;
//            }
//            else
//            {
//                Console.WriteLine("Помилка");
//            }
//        } while (!isValid);

//        return number;
//    }
//}