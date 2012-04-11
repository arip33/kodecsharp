using System;

namespace Kodecsharp.Example.Intro
{
    class SwitchDemo
    {
        [STAThread]
        public static void Main(string[] args)
        {
            // Prompt user a message to enter a week day.
            Console.Write("Please enter week day: ");
            // Read user input value and convert it into integer value
            int day = Int32.Parse(Console.ReadLine());

            // Declare a variable to hole the dayName value.
            string dayName = "";

            //
            // Use the switch statement to check which week day value is
            // entered by the user.
            //
            switch (day)
            {
                case 1:
                    dayName = "Sunday";
                    break;
                case 2:
                    dayName = "Monday";
                    break;
                case 3:
                    dayName = "Tuesday";
                    break;
                case 4:
                    dayName = "Wednesday";
                    break;
                case 5:
                    dayName = "Thursday";
                    break;
                case 6:
                    dayName = "Friday";
                    break;
                case 7:
                    dayName = "Saturday";
                    break;
                default:
                    dayName = "Wrong input. Should be between 1 - 7";
                    break;
            }

            // Print out the selected week day.
            Console.WriteLine("Day name: " + dayName);
            Console.ReadLine();
        }
    }
}