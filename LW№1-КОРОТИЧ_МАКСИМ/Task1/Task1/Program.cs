using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Address
    {
        public int Index { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public int House { get; set; }
        public int Apartment { get; set; }
    }

    class Program1
    {
        static void Main()
        {
            var address = new Address
            {
                Index = 12345,
                Country = "Україна",
                City = "Київ",
                Street = "Хрещатик",
                House = 1,
                Apartment = 101
            };

            Console.WriteLine("Поштова адреса:");
            Console.WriteLine($"Індекс: {address.Index}");
            Console.WriteLine($"Країна: {address.Country}");
            Console.WriteLine($"Місто: {address.City}");
            Console.WriteLine($"Вулиця: {address.Street}");
            Console.WriteLine($"Будинок: {address.House}");
            Console.WriteLine($"Квартира: {address.Apartment}");
        }
    }
}
