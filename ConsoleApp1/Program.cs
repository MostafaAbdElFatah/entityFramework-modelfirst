using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.db;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            DatabaseManager db = new DatabaseManager();
            db.addProduct(new Product() { name="product 3",price = 60.6,quantity=150 });
            List<Product> products = db.getAllProducts();

            System.Console.WriteLine("*************** Old Value*******************");
            foreach (Product p in products) {
                System.Console.WriteLine(
                    "id         = " + p.id +
                    "\nname     = " + p.name +
                    "\nprice    = " + p.price +
                    "\nquantity = " + p.quantity );
                System.Console.WriteLine("**********************************");
            }
            /*
            for(int i =0;i < products.Count;i++)
            {
                products[i].name = "asd " + i;
                products[i].price = i + 2.5;
                products[i].quantity = (1 + i)*10;
                db.updateProduct(products[i]);
            }*/
            db.deleteProduct(products[products.Count - 1]);
            //db.deleteProduct(products[2]);
            System.Console.WriteLine("*************** new Value*******************");
            foreach (Product p in db.getAllProducts())
            {
                System.Console.WriteLine(
                    "id         = " + p.id +
                    "\nname     = " + p.name +
                    "\nprice    = " + p.price +
                    "\nquantity = " + p.quantity);
                System.Console.WriteLine("**********************************");
            }
            System.Console.Read();
        }
    }
}
