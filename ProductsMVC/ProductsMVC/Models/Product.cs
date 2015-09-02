using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [DisplayName("Image")]
        [DataType(DataType.ImageUrl)]
        public string ImageURL { get; set; }
        public int CategoryId { get; set; }
       [ForeignKey("CategoryId")]
        public Category Category { get; set; }

    }
        public class Category
        {
            [Key]
            public int CategoryId { get; set; }
            public string CategoryName { get; set; }
            public string Description { get; set; }

            public virtual ICollection<Product> Products { get; set; }
        }
       
   
    public class  ProductDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }

}