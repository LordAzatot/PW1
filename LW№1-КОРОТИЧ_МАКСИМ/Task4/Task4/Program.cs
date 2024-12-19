using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class User
    {
        public string Login { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfForm { get; } // Поле тільки для читання

        public User()
        {
            DateOfForm = DateTime.Now; // Ініціалізується при створенні об'єкта
        }
    }

    class Program3
    {
        static void Main()
        {
            var user = new User();

            Console.Write("Введіть логін: ");
            user.Login = Console.ReadLine();

            Console.Write("Введіть ім'я: ");
            user.FirstName = Console.ReadLine();

            Console.Write("Введіть прізвище: ");
            user.LastName = Console.ReadLine();

            Console.Write("Введіть вік: ");
            user.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("\nІнформація про користувача:");
            Console.WriteLine($"Логін: {user.Login}");
            Console.WriteLine($"Ім'я: {user.FirstName}");
            Console.WriteLine($"Прізвище: {user.LastName}");
            Console.WriteLine($"Вік: {user.Age}");
            Console.WriteLine($"Дата заповнення анкети: {user.DateOfForm}");
        }
    }
}