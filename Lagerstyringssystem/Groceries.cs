using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    internal class Groceries : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime Expiration { get; set; }

        public Groceries(string name, double price, DateTime expiration)
        {
            Name = name;
            Price = price;
            Expiration = expiration;
        }

        public void PrintInfo()
        { 
            Console.WriteLine();
           Console.WriteLine($"Name:               {Name}");
           Console.WriteLine($"Price:              {Price}");
           Console.WriteLine($"Expiration date     {Expiration}");
        }
    }
}
