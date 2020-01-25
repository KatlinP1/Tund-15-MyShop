using System;

namespace MyShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a warehouse object
            Warehouse currentlyInStock =new Warehouse();
            //Creat shoping cart object 
            ShoppingCart shoppingCart=new ShoppingCart();
            //display the warehouse content
            currentlyInStock.PrintInStock();

            AddItemsToShoppingCart(currentlyInStock,shoppingCart);

            while (true)
            {
                Console.WriteLine("Add/Remove/Confirm");
                string userInput = Console.ReadLine().ToLower();
                if (userInput=="add")
                {
                    AddItemsToShoppingCart(currentlyInStock,shoppingCart);
                } 
                else if (userInput == "remove")
                {
                    Console.WriteLine("Enter the id of the project to remove from the shopping cart:");
                    int itemIdToRemove = int.Parse(Console.ReadLine());
                    shoppingCart.RemoveFromShoppingCart(itemIdToRemove);
                }
                else if (userInput == "confirm")
                {
                    shoppingCart.PrintTotal();
                    Console.WriteLine($"Shopping cart total: {shoppingCart.Total}");
                    break;
                }
            }
        }
        public static void AddItemsToShoppingCart(Warehouse currentlyInStock, ShoppingCart shoppingCart)
        {
            Console.WriteLine("Enter the id of the project to add it to the shopping cart:");
            int productID = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number of the items you want to add to the shopping cart:");
            int quantity = int.Parse(Console.ReadLine());

            Console.WriteLine("Would you like to add smt.");

            Article articleToAdd = currentlyInStock.GetFromStock(productID);
            shoppingCart.AddToShoppingCart(articleToAdd,quantity);
            shoppingCart.PrintShoppingCart();
        }
    }
}