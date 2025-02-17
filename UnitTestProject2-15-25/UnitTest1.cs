using ConsoleApp1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//namespace UnitTestProject2_15_25
namespace UnitTestProject2_15_25
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestListLength()
        {
            ProductController controller = new ProductController();
            List<Product> ListOfProducts = controller.CreateList();
     
            Assert.AreEqual(ListOfProducts.Count, 2);

        }

        [TestMethod]
        public void TestListContentAt0Position()
        {
            ProductController controller = new ProductController();
            List<Product> ListOfProducts = controller.CreateList();

            Assert.AreEqual(ListOfProducts[0].Name, "Laptop");
        }
        [TestMethod]
        public void TestListContentAtPosition1()
        {
            ProductController controller = new ProductController();
            List<Product> ListOfProducts = controller.CreateList();

            Assert.AreEqual(ListOfProducts[1].Name, "Printer");
        }
        [TestMethod]
        public void TestProductListLength()
        {
            ProductController controller = new ProductController();
            List<Product> ListOfProducts = controller.CreateList();

            controller.DisplayList(ListOfProducts);


            Assert.AreEqual(ListOfProducts.Count, 2);
        }


    }
}
