using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsCatalog
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductStorage storage = new ProductStorage();
            //Add a product

            do
            {
                Console.WriteLine("Time to create an object. Please enter the following information.");
                Console.Write("ProductName:");
                string name = Console.ReadLine();
                Console.Write("ProductID");
                int id = Int32.Parse(Console.ReadLine());

                Product product = new Product();
                product.ProductName = name;
                product.ProductID = id;
                //..


                storage.AddNewProduct(product);
                Console.WriteLine("Product added.");
                Console.WriteLine("Enter esc to quit");
     
            } while (Console.ReadKey().Key != ConsoleKey.Escape);

            Console.Write("Enter ProductID to remove:");
            int ID = Int32.Parse(Console.ReadLine());
            storage.RemoveProductID(ID);

            Console.WriteLine("Thank you sir!");
        }
    }
}
