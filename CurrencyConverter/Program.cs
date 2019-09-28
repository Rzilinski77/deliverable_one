using System;
using System.Globalization;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] currencyArray = new double[3];
            double total = 0;
            double count = 0;
            double smallestAmount;
            double largestAmount;

            Console.WriteLine("Please enter your first dollar amount");
            string dollarOne = Console.ReadLine();
            currencyArray[0] = Convert.ToDouble(dollarOne);

            Console.WriteLine("Please enter your second dollar amount");
            string dollarTwo = Console.ReadLine();
            currencyArray[1] = Convert.ToDouble(dollarTwo);

            Console.WriteLine("Please enter your third dollar amount");
            string dollarThree = Console.ReadLine();
            currencyArray[2] = Convert.ToDouble(dollarThree);

            for (int i = 0; i <= 2; i++)
            {
                count++;
                total = total + currencyArray[i];
            }
            Console.WriteLine("Average Dollar Amount: $" + (total / count));

            smallestAmount = currencyArray[0];

            for (int i = 0; i <= 2; i++)
            {
                if (smallestAmount > currencyArray[i])
                {
                    smallestAmount = currencyArray[i];
                }
            }
            Console.WriteLine("Smallest Amount: " + smallestAmount);

            largestAmount = currencyArray[0];

            for (int i = 0; i <= 2; i++)
            {
                if (largestAmount < currencyArray[i])
                {
                    largestAmount = currencyArray[i];
                }
            }
            Console.WriteLine("Largest Amount: $" + largestAmount);
            Console.WriteLine("");
            Console.WriteLine("Total:");
            Console.WriteLine("US: " + total.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine("Swedish: " + total.ToString("C", CultureInfo.CreateSpecificCulture("da-DK")));
            Console.WriteLine("Japanese: " + total.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
            Console.WriteLine("Thai: " + total.ToString("C", CultureInfo.CreateSpecificCulture("th-TH")));





























































        }
    }
}
