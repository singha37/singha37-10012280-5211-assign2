using System;

namespace question04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print out the reverse timestables (highest number first) for:");

            var number = Convert.ToInt32(Console.ReadLine());

            for(int a = 12; a > 0; a--) {
                
                Console.WriteLine($"{a} x {number} = {a * number}");
            }
        }
    }
}