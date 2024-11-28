using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lagerstyringssystem
{
    internal class Inventory
    {
        public List<IProduct> Products { get; set; } = new List<IProduct>();

      

        public void MainMenu()
        {
            Console.WriteLine();
            Console.WriteLine("         Type the number of what you want to do");
            Console.WriteLine("1. Add new product");
            Console.WriteLine("2. Remove product");
            Console.WriteLine("3. View inventory");
        }

        public void AddProductMenu()
        {
            Console.WriteLine("1. Electronics");
            Console.WriteLine("2. Groceries");
            Console.WriteLine("3. Clothes");
        }

        public void AddProduct(string userInput)
        {
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("Category:  Electronics");
                    Console.Write("Name:            ");
                    string elName = Console.ReadLine();
                    Console.Write("Price:           ");
                    double elPrice = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Warranty(Months):");
                    int warranty = Convert.ToInt32(Console.ReadLine());
                    Electronics newElectronic = new Electronics(elName, elPrice, warranty);
                    Products.Add(newElectronic);
                    break;
                case "2":
                    Console.WriteLine("Category:  Groceries");
                    Console.Write("Name:            ");
                    string grocName = Console.ReadLine();
                    Console.Write("Price:           ");
                    double grocPrice = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Expiration Date:");
                    DateTime expiration = Convert.ToDateTime(Console.ReadLine());
                    Groceries newGrocerie = new Groceries(grocName, grocPrice, expiration);
                    Products.Add(newGrocerie);
                    break;
                case "3":
                    Console.WriteLine("Category:  Clothes");
                    Console.Write("Name:            ");
                    string clName = Console.ReadLine();
                    Console.Write("Price:           ");
                    double clPrice = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Size:");
                    int size = Convert.ToInt32(Console.ReadLine());
                    Clothes newClothes = new Clothes(clName, clPrice, size);
                    Products.Add(newClothes);
                    break;
            }

        }

        public IProduct FindProductByName(string name)
        {
            foreach (var product in Products)
            {
                if (product.Name == name) return product;
            }

            Console.WriteLine("No product with that name found");
            return null;
        }

        public void AddProduct(IProduct item)
        {
            Products.Add(item);
        }

        public void RemoveProduct(IProduct item)
        {
            Console.WriteLine($"Removing {item.Name} from the inventory");
            Thread.Sleep(1000);
            Products.Remove(item);
        }

        public void ShowAllProducts()
        {
            foreach (var product in Products)
            {
                product.PrintInfo();
            }
        }
    }
}

   
