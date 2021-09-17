using System;
  
namespace Task61
{
  class Program
  {
    static void Main()
    {
      int a1=0,a2=0;
      int[] data=Array.ConvertAll(Console.ReadLine().Split(' '),i=>Convert.ToInt32(i));
      a1+=data[0];
      a2+=data[1];
      data=Array.ConvertAll(Console.ReadLine().Split(' '),i=>Convert.ToInt32(i));
      a1+=data[0];
      a2+=data[1];
      data=Array.ConvertAll(Console.ReadLine().Split(' '),i=>Convert.ToInt32(i));
      a1+=data[0];
      a2+=data[1];
      data=Array.ConvertAll(Console.ReadLine().Split(' '),i=>Convert.ToInt32(i));
      a1+=data[0];
      a2+=data[1];
      Console.Write((a1==a2)?"DRAW":(a1>a2)?"1":"2");
    }
  }
}
