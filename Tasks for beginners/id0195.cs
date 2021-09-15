using System;
 
namespace Task0195
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = Console.ReadLine().Split(' ');
            Console.Write(Convert.ToInt32(d[0]) * Convert.ToInt32(d[1]) * Convert.ToInt32(d[2]) * 2);
        }
    }
}
