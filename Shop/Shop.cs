using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    public class Shop
    {
        private List<Product> products = new List<Product>();

        //public List<Product> Products {
        //    get { return this.products; }
        //}
        //public Shop(List<Product> list)
        //{
        //    this.products = list; ;
        //}
        private Product DaLi (Product pro)
        {
            if (products.Where(z => z.Barcode == pro.Barcode).First() == null|| products.IndexOf(pro) == -1)
            //if (products.Count ==0 || products.IndexOf(pro)==-1)
            {
                return null;
            }
            else
            {
                //return products.Where(z.Barcode => z == pro.Barcode).First();
                return products[products.IndexOf(pro)];
            }
        }

        public Product Sell(string barcode, double quantity)
        {
            Product proForSell = new Product(barcode,"",0.0, quantity);
            Product finn =  DaLi(proForSell);
            if (finn.Quantity <= quantity )
            {
                Console.WriteLine("Not enough quantity");
                return null; //nqma da izdavam syob
            }
            finn.Quantity = finn.Quantity - quantity;
            return finn;
        }
        public void Add(string barcode, string name,double price, double quantity) {
            Product newpr = new Product(barcode, name, price, quantity);
            if (products.Contains(newpr))
            {
                Console.WriteLine("Incorrect product!");
                return;
            }
            products.Add(newpr);
            Console.WriteLine("Da + " + newpr.ToString());
        }
        public Product Update(string barcode, double quantity)
        {
            Product proForSell = new Product(barcode, "", 0.0, quantity);
            Product finn = DaLi(proForSell);
            if (finn == null)
            {
                Console.WriteLine("Please add your product first!");
                return null; //nqma da izdavam syob
            }
            finn.Quantity = finn.Quantity + quantity;
            return finn;
        }
        public void PrintA() {
            products.Sort();
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine(products[i]);//ToString     

            }
            
        }
    }
}
