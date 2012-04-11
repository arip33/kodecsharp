using System;

namespace Kodecsharp.Example.Intro
{
    class CommentExample
    {
        [STAThread]
        public static void Main()
        {
            // Assign Alice to name.
            String name = "Alice"; // This is a single line comment.
            Console.WriteLine("Name: " + name);

            /*
             * A multiline comments.
             * Creates an array of integer numbers and prints its
             * value using the foreach statement.
             */
            int[] numbers = { 1, 1, 2, 3, 5, 8, 13, 21 };
            foreach (int number in numbers)
            {
                Console.WriteLine("Number: " + number);
            }

            // Call the sayHello() method.
            sayHello("Jane");
            sayHello(null);
            Console.ReadLine();
        }

        /// <summary>
        /// This method prints a hello message to the user.
        /// </summary>
        /// <param name="name">The name of the user</param>
        public static void sayHello(string name)
        {
            if (name != null && !name.Trim().Equals(""))
            {
                Console.WriteLine("Hi, Hello " + name + "!");
            }
            else
            {
                Console.WriteLine("Hi, Hello There!");
            }
        }
    }
}