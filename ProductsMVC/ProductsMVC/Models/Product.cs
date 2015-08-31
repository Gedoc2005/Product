using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ProductsMVC.Models
{
    public class Product
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public float Price { get; set; }
        public long ArticleNumber { get; set; }
        public string ImegeURL { get; set; }

       
    }
    public class  ProductDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
    }
}