using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            HelloWorld();
            Console.ReadLine();
        }

        private static void HelloWorld()
        {
            int numberOfItem = 0;
            Console.WriteLine("Hello world");
            Console.WriteLine("my number is {0} {1}", numberOfItem, 7);
            Console.WriteLine("my number is way two num = " + numberOfItem);
        }
    }
}