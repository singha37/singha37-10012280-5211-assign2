﻿using System;

namespace question05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out the division table for:");

            var number = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < 12; i++) {
                var a = i + 1;
                Console.WriteLine($"{a} x {number} = {a / number}");
            }
        }
    }
}
