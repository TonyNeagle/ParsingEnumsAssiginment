using System;

namespace DayOfWeekApp
{
    // Define an enum containing the days of the week to restrict possible values
    public enum Days
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Boolean flag to track whether a valid day has been successfully entered
            bool isValidEntry = false;

            // Variable to store the final successfully parsed enum value
            Days currentDay;

            // Use a while loop to keep asking the user until they provide a valid day
            while (!isValidEntry)
            {
                // Prompt the user to enter a day of the week
                Console.WriteLine("Please enter the current day of the week:");

                // Read the user's input and store it as a string
                string userInput = Console.ReadLine();

                // Wrap the parsing and assignment in a try block to handle any errors
                try
                {
                    // Attempt to parse the string to the enum; ignores capitalization
                    if (Enum.TryParse<Days>(userInput, true, out currentDay))
                    {
                        // Set the flag to true to break out of the while loop
                        isValidEntry = true;

                        // Print the final successful selection to the console
                        Console.WriteLine($"Success! You selected: {currentDay}");
                    }
                    else
                    {
                        // If TryParse returns false, manually throw an exception to trigger the catch block
                        throw new ArgumentException();
                    }
                }
                // Catch block triggered if the input cannot be parsed or an invalid day is entered
                catch (Exception)
                {
                    // Print the requested error message to the console
                    Console.WriteLine("Please enter an actual day of the week.");

                    // Print an extra line separator for cleaner formatting on the next try
                    Console.WriteLine();
                }
            }

            // Keep the console window open until the user presses a key
            Console.ReadLine();
        }
    }
}
