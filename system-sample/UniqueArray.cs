using System;

namespace Kodecsharp.Example.System
{
    class UniqueArray
    {
        /// <summary>
        /// Returns true if the array doesn't contains the number.
        /// </summary>
        public static bool isUnique(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// Convert the given array into another array with unique 
        /// values.
        /// </summary>
        public static int[] toUniqueArray(int[] array)
        {
            int[] temp = new int[array.Length];
            for (int i = 0; i < temp.Length; i++)
            {
                temp[i] = -1;
            }

            int counter = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (isUnique(temp, array[i])) 
                {
                    temp[counter++] = array[i];
                }
            }

            int[] uniqueArray = new int[counter];
            Array.Copy(temp, 0, uniqueArray, 0, uniqueArray.Length);
            return uniqueArray;
        }

        /// <summary>
        /// Print the content of given array
        /// </summary>
        public static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine("");
        }

        public static void Main(string[] args)
        {
            int[] array = { 1, 1, 2, 3, 4, 1, 4, 7, 9, 7 };
            printArray(array);
            printArray(toUniqueArray(array));
        }
    }
}
