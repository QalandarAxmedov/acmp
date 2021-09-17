using System;
   
namespace Task0766
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = Array.ConvertAll(Console.ReadLine().Split(' '),i=>Convert.ToInt32(i));
            Console.WriteLine((d[0]*d[1]>=d[2]) ? "YES" : "NO");
        }
    }
}
