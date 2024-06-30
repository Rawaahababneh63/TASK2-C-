using System;

namespace Task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //    // double result =Convert.ToDouble(task4.summationAndAvg());
            var result = Operation.SummationAndAvg();
            Console.WriteLine($"The sum of 10 no is : {result.sum}");
            Console.WriteLine($"The averge of 10 no is : {result.avg}");

           Operation.CubicNum();
            Console.ReadLine();


        }
    }
}
