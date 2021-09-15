using System;
 
namespace Task0025
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            string c = (a > b) ? ">" : (a < b) ? "<" : "=";
            Console.WriteLine(c);
        }
    }
}
