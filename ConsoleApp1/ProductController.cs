using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    public class ProductController
    {
        public  List<Product> CreateList()
        {
            List<Product> List1 = new List<Product>();

            List1.Add(new Product { ID = 1, Name="Laptop", Price=500m }) ;
            List1.Add(new Product {ID=2, Name="Printer", Price=200m });


            return List1;
           // throw new NotImplementedException();
        }

        public void DisplayList(List<Product> productListToDisplay)
        {
            for (int i=0; i<productListToDisplay.Count; i++)
            {
                Console.WriteLine($"{productListToDisplay[i].ID}, {productListToDisplay[i].Name}, {productListToDisplay[i].Price}");
            }
           
        }
    }
}
