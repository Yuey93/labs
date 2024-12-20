using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using static QAShopping.ShoppingConstants;

namespace QAShopping
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ShoppingItem> myBasket = new List<ShoppingItem>();

            // Constants for item prices
            dynamic item1 = new ShoppingItem(1, "Baked Beans", PRICE_BAKED_BEANS, false);
            myBasket.Add(item1);
            Console.WriteLine(Basket.PrintBasket(myBasket));
            Console.WriteLine();

            // Constants for item prices
            dynamic item2 = new ShoppingItem(2, "Battenburg Cake", PRICE_BATTENBURG_CAKE, true);
            myBasket.Add(item2);
            Console.WriteLine(Basket.PrintBasket(myBasket));
            Console.WriteLine();

            // Constants for item prices
            dynamic item3 = new ShoppingItem(3, "Grannary Loaf", PRICE_GRANNARY_LOAF, false);
            myBasket.Add(item3);
            Console.WriteLine(Basket.PrintBasket(myBasket));
            Console.WriteLine();

            // Constants for item prices
            dynamic item4 = new ShoppingItem(4, "Bottle of Red Wine", PRICE_BOTTLE_OF_RED_WINE, true);
            myBasket.Add(item4);
            Console.WriteLine(Basket.PrintBasket(myBasket));
            Console.WriteLine();
        }
    }
}
