using System;
   
namespace Task773
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = Array.ConvertAll(Console.ReadLine().Split(' '),i=>Convert.ToInt32(i));
            Console.Write(d[0]*d[0]*d[1]);
        }
    }
}
