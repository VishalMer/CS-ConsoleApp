using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_P1
{
    internal class staticUpdate
    {
        public static class Author
        {
            public static string name = "XYZ";
            public static string title = "Title";

            public static void display()
            {
                Console.WriteLine("Author name is :" + name);
                Console.WriteLine("Author title is :" + title);
            }
            public static void update()
            {
                name = "ABC";
            }
        }

        class staticDemo
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Author Information :");
                Author.display();

                Console.WriteLine("Updated Author Information : ");
                Author.update();
                Author.display();
            }
        }
    }
}
