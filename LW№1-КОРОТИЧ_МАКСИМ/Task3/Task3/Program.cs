using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Employee
    {
        public string LastName { get; }
        public string FirstName { get; }
        public string Position { get; set; }
        public int Experience { get; set; }

        public Employee(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public double CalculateSalary()
        {
            double baseSalary = Position.ToLower() switch
            {
                "junior" => 20000,
                "middle" => 30000,
                "senior" => 50000,
                _ => 25000
            };

            double experienceBonus = Experience switch
            {
                >= 10 => 0.3, // 30% надбавки
                >= 5 => 0.2,  // 20% надбавки
                _ => 0.1      // 10% надбавки
            };

            return baseSalary + (baseSalary * experienceBonus);
        }

        public double CalculateTax() => CalculateSalary() * 0.18; // 18% податок
    }

    class Program2
    {
        static void Main()
        {
            Console.Write("Введіть прізвище співробітника: ");
            string lastName = Console.ReadLine();

            Console.Write("Введіть ім'я співробітника: ");
            string firstName = Console.ReadLine();

            Console.Write("Введіть посаду (Junior/Middle/Senior): ");
            string position = Console.ReadLine();

            Console.Write("Введіть стаж роботи (у роках): ");
            int experience = int.Parse(Console.ReadLine());

            var employee = new Employee(lastName, firstName)
            {
                Position = position,
                Experience = experience
            };

            double salary = employee.CalculateSalary();
            double tax = employee.CalculateTax();

            Console.WriteLine("\nІнформація про співробітника:");
            Console.WriteLine($"Прізвище: {employee.LastName}");
            Console.WriteLine($"Ім'я: {employee.FirstName}");
            Console.WriteLine($"Посада: {employee.Position}");
            Console.WriteLine($"Оклад: {salary:F2} грн");
            Console.WriteLine($"Податковий збір: {tax:F2} грн");
        }
    }
}