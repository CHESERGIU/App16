using System;

namespace App16
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine(); 
            double first = Convert.ToSingle(inputData);
            inputData = Console.ReadLine(); 
            double second = Convert.ToSingle(inputData);
            double min = Math.Round((second < first ? second : first), 2);
            Console.WriteLine(min);
        }
    }
}
