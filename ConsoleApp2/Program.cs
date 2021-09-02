using System;

namespace ConsoleApp2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //int a = 1;
            //int b;
            //while (a < 5)
            //{
            //    Console.WriteLine("enter number");
            //    b = Convert.ToInt32(Console.ReadLine());
            //    if (b < 0)
            //        break;
            //    a = a + 1;
            //}

            //Console.ReadLine();
            int a = 1;
            while (a < 10)
            {
                Console.WriteLine(a);
                a = a + 1;
            }
            Math.Min(5, 10);
            Console.ReadLine();
        }
    }
}