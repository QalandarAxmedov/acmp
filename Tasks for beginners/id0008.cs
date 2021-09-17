using System;
   
namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            var o = Array.ConvertAll(Console.ReadLine().Split(' '),i=>Convert.ToInt32(i));
            Console.Write((o[0]*o[1]==o[2]) ? "YES" : "NO");
        }
    }
}
