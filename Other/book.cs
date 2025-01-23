using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4BCAA
{
    class book
    {

        double price;
        string colour;
        int pages;

        //public void getData(double price, string colour,int pages)
        //{
        //    this.price = price;
        //    this.colour = colour;
        //    this.pages = pages;
        //}

        //OR

        public void getData()
        {
            Console.Write("Enter book price : ");
            price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter book colour : ");
            colour = Console.ReadLine();

            Console.Write("Enter book pages : ");
            pages = Convert.ToInt32(Console.ReadLine());
        }

        public void showData()
        {
            Console.WriteLine("Price of the book is : " + price);
            Console.WriteLine("Pages of the book is : " + pages);
            Console.WriteLine("Colour of the book is : " + colour);
        }
    }
    class book1
    {
        public static void Main(string[] args)
        {
            //book book1 = new book();
            //Console.WriteLine("Book 1 details : ");
            //book1.getData(10,"red",50);
            //book1.showData();
            //Console.WriteLine();


            //book book2 = new book();
            //Console.WriteLine("Book 2 details : ");
            //book2.getData(200, "blue", 500);
            //book2.showData();

            //OR

            book book1 = new book();
            book book2 = new book();
            Console.WriteLine("Enter book 1 details : ");
            book1.getData();
            Console.WriteLine();

            Console.WriteLine("Enter book 2 details : ");
            book2.getData();
            Console.WriteLine();

            Console.WriteLine("Book 1 details : ");
            book1.showData();
            Console.WriteLine();

            Console.WriteLine("Book 2 details : ");
            book2.showData();
        }
    }

}
