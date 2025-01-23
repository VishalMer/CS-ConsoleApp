using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCAA.Assignment_1
{
    public class product
    {
        int p_id;
        string p_name;
        double p_price;

        public product()
        {
            Console.WriteLine("Enter productid: ");
            p_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter product name: ");
            p_name = Console.ReadLine();

            Console.WriteLine("Enter price: ");
            p_price = Convert.ToDouble(Console.ReadLine());
        }

        public void showData()
        {
            Console.WriteLine("Product ID : " + p_id);
            Console.WriteLine("Product Name : " + p_name);
            Console.WriteLine("Product Price : " + p_price);
        }
    }

    public class productTest
    {
        static void Main(string[] args)
        {
            product [] p = new product[5];
            for (int i = 0; i<5; i++)
            {
                p[i] = new product();
            }
            for (int i = 0; i < 5; i++)
            {
                p[i].showData();
            }
        }
    }
}
