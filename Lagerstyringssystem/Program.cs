using System.Diagnostics.CodeAnalysis;
using Lagerstyringssystem;

Inventory MainInventory =  new Inventory();

Electronics item1 = new Electronics("Apple phone charger", 599.99, 6);
Electronics item2 = new Electronics("Lenovo Laptop", 2990, 24);

Groceries item3 = new Groceries("Minced Meat", 79.90, new DateTime(2024, 06, 15));
Groceries item4 = new Groceries("Eggs", 79.90, new DateTime(2024, 06, 15));

Clothes item5 = new Clothes("T-shirt", 199.90, 32);
Clothes item6 = new Clothes("Winter boots", 999.90, 42);

MainInventory.Products.Add(item1);
MainInventory.Products.Add(item2);
MainInventory.Products.Add(item3);
MainInventory.Products.Add(item4);
MainInventory.Products.Add(item5);
MainInventory.Products.Add(item6);

while (true)
{
    MainInventory.MainMenu();
    string userInput = Console.ReadLine();
    switch (userInput)
    {
        case "1":
            Console.WriteLine("What kind of product do you want to add?");
            MainInventory.AddProductMenu();
            userInput = Console.ReadLine();
            MainInventory.AddProduct(userInput);
            break;

        case "2":
            Console.WriteLine("Type the name of the product you want to remove");
            string input = Console.ReadLine();
            IProduct product = MainInventory.FindProductByName(input);
            if (product != null)
            {
                MainInventory.RemoveProduct(product);
            }
            break;
        case "3":
            MainInventory.ShowAllProducts();
            break;
        default:
            Console.WriteLine("Not a valid command");
            break;
    }
}
