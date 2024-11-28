using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    internal class Clothes : IProduct
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Size { get; set; }

        public Clothes(string name, double price, int size)
        {
            Name = name;
            Price = price;
            Size = size;
        }
        
        public void PrintInfo()
        {
            Console.WriteLine();
            Console.WriteLine($"Name:               {Name}");
            Console.WriteLine($"Price:              {Price}");
            Console.WriteLine($"Size:               {Size}");
        }
    }
}
