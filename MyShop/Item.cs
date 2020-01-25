using System;

namespace MyShop
{
    class Item
    {
       Article article;
       int quantity;

       public Item(Article _article, int _quantity)
       {
           article = _article;
           quantity = _quantity;
       }

       public Article Article
       {
           get { return article; }
       }

       /*public string Article
       {
           get{ return $" ID: {article.Id} \n Name: {article.Name} \n Category: {article.Category} \n Price: {article.Price} \n Quantity: {quantity}" +
               $" Total: {CalculateItemTotal()}";
           }
       }*/

       public void PrintItem()
       {
           Console.WriteLine($" ID: {article.Id} \n Name: {article.Name} \n Category: {article.Category} \n Price: {article.Price} \n Quantity: {quantity}" +
                             $" Total: {CalculateItemTotal()}");
       }
       
       public double CalculateItemTotal()
       {
           return article.Price * quantity;
       }

    
       
    }
}