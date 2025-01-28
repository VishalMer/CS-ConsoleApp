using System;

namespace _4BCA
{
    internal class staticDemo
    {

        public static class Author
        {
            public static string name = "XYZ";
            public static string title = "Title";

            public static void display()
            {
                Console.WriteLine("Author name is :" + name);
                Console.WriteLine("Author title is :" + name);
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
