// // Task 2

//using System;
//class AgeChecker
//{
//    static void Main()
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        bool continueLoop = false;

//  // Основний цикл do/while
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
//                   // Логіка класифікації віку
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
