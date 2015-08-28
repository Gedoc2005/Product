using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProductsCatalog
{
    public class ProductStorage
    {
        private List<Product> productdb = new List<Product>();

        public ProductStorage()
        {

        }
        public void AddNewProduct(Product p)
            
        {
            productdb.Add(p);
        }
        public int ProductCount()
        {
            return productdb.Count;
        }

        public void RemoveProductID (int productid)
        {
            foreach (var product in productdb)
            {
                if(product.ProductID == productid)
                {
                    productdb.Remove(product);
                    break;
                }
            }
        }
    }

}
