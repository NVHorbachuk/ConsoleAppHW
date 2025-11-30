//using System;
//using System.Collections.Generic;
//using System.Linq;
//class Student
//{
//    public string FirstName { get; set; }
//    public string LastName { get; set; }
//    public int Age { get; set; }
//    public string Specialty { get; set; }

//    public Student(string firstName, string lastName, int age, string specialty)
//    {
//        FirstName = firstName;
//        LastName = lastName;
//        Age = age;
//        Specialty = specialty;
//    }

//    public override string ToString()
//    {
//        return $"[Студент: {FirstName} {LastName}, Вік: {Age}, Спеціальність: {Specialty}]";
//    }
//}

//class StudentManager
//{
//    static void Main(string[] args)
//    {
//        Console.OutputEncoding = System.Text.Encoding.UTF8;
//        Console.WriteLine("Система Керування Студентами");

//        List<Student> students = new List<Student>
//        {
//            new Student("Іван", "Коваленко", 21, "Інформатика"),
//            new Student("Марія", "Петренко", 19, "Філологія"),
//            new Student("Олександр", "Сидоренко", 25, "Право"),
//            new Student("Наталія", "Мельник", 20, "Економіка"),
//            new Student("Віталій", "Кравченко", 25, "Інформатика"),
//            new Student("Дар'я", "Ткаченко", 22, "Медицина")
//        };

//        Console.WriteLine("Початковий список студентів:");
//        foreach (var student in students)
//        {
//            Console.WriteLine(student);
//        }
        
//        int minAge = 20;
//        Console.WriteLine($"\nФільтрація: Студенти старше {minAge} років:");

//        var olderStudents = students.Where(s => s.Age > minAge).ToList();

//        if (olderStudents.Any())
//        {
//            foreach (var student in olderStudents)
//            {
//                Console.WriteLine(student);
//            }
//        }
//        else
//        {
//            Console.WriteLine("Студентів, старших за 20 років, не знайдено.");
//        }
//        Console.WriteLine("Пошук: Найстарший студент:");

//        Student oldestStudent = students
//            .OrderByDescending(s => s.Age)
//            .FirstOrDefault();

//        if (oldestStudent != null)
//        {
//            Console.WriteLine($"Найстарший студент: {oldestStudent}");

//            int maxAge = oldestStudent.Age;
//            var allOldestStudents = students.Where(s => s.Age == maxAge).ToList();

//            if (allOldestStudents.Count > 1)
//            {
//                Console.WriteLine($"\nУвага: Кілька студентів мають вік {maxAge}:");
//                foreach (var student in allOldestStudents)
//                {
//                    Console.WriteLine(student);
//                }
//            }
//        }
//        else
//        {
//            Console.WriteLine("Список студентів порожній.");
//        }

//        Console.WriteLine("Натисніть будь-яку клавішу для виходу...");
//        Console.ReadKey();
//    }
//}