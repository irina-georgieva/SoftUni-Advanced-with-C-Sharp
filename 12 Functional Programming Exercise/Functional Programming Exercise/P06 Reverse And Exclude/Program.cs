﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, bool> isDivisible = (n, m) => n % m == 0;

            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int divNumber = int.Parse(Console.ReadLine());

            int[] result = numbers.Where(x => !isDivisible(x, divNumber)).Reverse().ToArray();

            Console.WriteLine(string.Join(" ", result));

        }
    }
}
