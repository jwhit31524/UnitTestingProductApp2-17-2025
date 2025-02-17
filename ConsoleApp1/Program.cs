using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductController controller = new ProductController();

            List<Product> ListOne = controller.CreateList();
            controller.DisplayList(ListOne);

            Console.ReadLine();

        }
    }
}
