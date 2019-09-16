using System;
using System.Collections.Generic;

namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            var listOfNumbers = new List<int>();
            var sum = 0;
            var sizeOfList = 10;
            for (var i = 0; i < sizeOfList; i++)
            {
                listOfNumbers.Add(rand.Next(0, 100));
                if (i % 2 == 0)
                {
                    sum += listOfNumbers[i];
                }
            }
            int penultPos = listOfNumbers.Count - 2;
            listOfNumbers.Sort();
            Console.WriteLine($"Index: {penultPos}  Value: {listOfNumbers[penultPos]}");
            Console.WriteLine($"Sum of elements in even positions: {sum}");

            Console.ReadKey();
        }
    }
}
