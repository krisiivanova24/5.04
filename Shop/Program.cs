using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Shop shop = new Shop();
            shop.Add(Convert.ToString(288), "meat", 7.26, 10 );
            shop.Sell(Convert.ToString(288), 10);
            Console.WriteLine(shop.ToString());
            shop.Add(Convert.ToString(288), "fruits", 4.30, 20);
            shop.Update(Convert.ToString(288), 4);
            Console.WriteLine(shop.ToString());
        }
    }
}
