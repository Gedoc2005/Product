using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProductsCatalog;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestofBoxSizePrintPass()
        {
            Size s = new BoxSize(1, 1, 1);
            string text = s.GetAsText();
            Assert.AreEqual("1x1x1 mm", text);
        }
        
        [TestMethod]
        public void AddProductToProductStoragePass()
        {
            Product p = new Product("Testprodukt", 1, "Testdescription", 1.0, new BoxSize(1, 1, 1), true);
            ProductStorage ps = new ProductStorage();
            ps.AddNewProduct(p);

            Assert.AreEqual(ps.ProductCount(), 1);
        }

        //[TestMethod]
        //public void RemoveProductFrom()
        //{
        //    Product p = new Product("Testprodukt", 1, "Testdescription", 1.0, new BoxSize(1, 1, 1), true);
        //    ProductStorage ps = new ProductStorage();
        //    ps.AddNewProduct(p);

        //    Assert.AreEqual(ps.ProductCount(), 1);
        //}
    }
}
