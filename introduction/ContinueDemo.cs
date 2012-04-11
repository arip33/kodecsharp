using System;

namespace Kodecsharp.Example.Intro
{
    class ContinueDemo
    {
        [STAThread]
        public static void Main(string[] args)
        {
            for (int i = 0; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
    }
}