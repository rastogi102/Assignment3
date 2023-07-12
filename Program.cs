using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // P-1: Understanding the Difference between TryParse, Convert, and Parse


            // Example using TryParse method to convert string to int

            //string intString = "789";
            //int intValue;
            //if (int.TryParse(intString, out intValue))
            //{
            //    Console.WriteLine("TryParse successful. Converted integer value: " + intValue);
            //}
            //else
            //{
            //    Console.WriteLine("TryParse failed. Invalid input string.");
            //}

            //// Example using Convert method to convert string to double
            //string doubleString = "5.35";
            //try
            //{
            //    double doubleValue = Convert.ToDouble(doubleString);
            //    Console.WriteLine("\n Convert successful. Converted double value: " + doubleValue);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("\n Convert failed. Invalid input format.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Convert failed. Input value is too large or too small.\n");
            //}

            //// Example using Parse method to convert string to decimal
            //string decimalString = "20.75";
            //try
            //{
            //    decimal decimalValue = decimal.Parse(decimalString);
            //    Console.WriteLine("Parse successful. Converted decimal value: " + decimalValue);
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Parse failed. Invalid input format.");
            //}
            //catch (OverflowException)
            //{
            //    Console.WriteLine("Parse failed. Input value is too large or too small.");
            //}

            //P2: Implementing Data Type Conversions using TryParse, Convert, and Parse

            // Convert a string to an integer using TryParse
            Console.WriteLine("Enter a number:");
            string numberString = Console.ReadLine();
            int number;
            if (int.TryParse(numberString, out number))
            {
                int result = number * 5;
                Console.WriteLine("Converted integer: " + result);
            }
            else
            {
                Console.WriteLine("Error converting string to integer.");
            }

            // Convert a string to a DateTime object using Convert
            Console.WriteLine("Enter a date (yyyy-MM-dd):");
            string dateString = Console.ReadLine();
            try
            {
                DateTime date = Convert.ToDateTime(dateString);
                DateTime previousMonth = date.AddMonths(-1);
                Console.WriteLine("Previous month: " + previousMonth.ToString("yyyy-MM-dd"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error converting string to DateTime.");
            }

            // Convert a string to a TimeSpan object using Parse
            Console.WriteLine("Enter a time (hh:mm:ss):");
            string timeString = Console.ReadLine();
            try
            {
                TimeSpan time = TimeSpan.Parse(timeString);
                TimeSpan newTime = time.Add(new TimeSpan(2, 0, 0));
                Console.WriteLine("New time: " + newTime.ToString(@"hh\:mm\:ss"));
            }
            catch (FormatException)
            {
                Console.WriteLine("Error converting string to TimeSpan.");
            }

        }

    }
}
