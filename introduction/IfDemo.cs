using System;

namespace Kodecsharp.Example.Intro
{
    public class IfDemo
    {
        [STAThread]
        public static void Main(string[] args)
        {
            //
            // Declares a variable i, j, k and assign a value to it.
            //
            int i = 2, j = 10, k = 20;

            // Check if i has the same value with j/
            if (i == j)
            {
                Console.WriteLine("i == j");
            }

            // Check if i is less than j or i is less than k.
            if ((i < j) || (i < k))
            {
                Console.WriteLine("i " + i + " is less that j or k");
            }

            // Check to see if i multiplied with j equals to the value of k.
            if (i * j == k)
            {
                Console.WriteLine("i * j = " + (i * j));
            }

            Console.ReadLine();
        }
    }
}