using System;
 
namespace task0766
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = Console.ReadLine().Split(' ');
            string a = (Convert.ToInt32(d[0]) * Convert.ToInt32(d[1]) >= Convert.ToInt32(d[2])) ? "YES" : "NO";
            Console.WriteLine(a);
        }
    }
}
