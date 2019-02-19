using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare & Initialize variables for money - note: Average could be a repeating decimal & Japanese currency is a whole-Integer amount
            Double Total = 0, high, low, Avg;
            Double[] dollar = new double[3];



            //use loop to iterate asking for 3 amounts
            for (int t = 0; t < 3; t++)
            {
                Console.WriteLine("Please input dollar amount: ");
                dollar[t] = Convert.ToDouble(Console.ReadLine());

            }
            //set inital values for 'high' and 'low' 
            low = dollar[0];
            high = dollar[0];

            //Compare the current value being looked at in the array against our dynamic values of high and low
            for (int i = 0; i < 3; i++)
            {
                if (dollar[i] < low)
                    low = dollar[i];

                if (dollar[i] > high)
                    high = dollar[i];
                //Total starts at 0, but increases by the value of each index in the array as the loop iterates
                Total += dollar[i];
            }
            //calculate the average amount and round to the nearest hundredths place for proper format
            Avg = Math.Round((Total / 3), 2);

            Console.WriteLine('\n' + "The Average dollar amount is: $" + Avg);
            Console.WriteLine("The lowest dollar amount is: $" + low);
            Console.WriteLine("The highest dollar amount is: $" + high + '\n');

            //Express the total in correct formats for each currency up to 2 decimal places
            Console.WriteLine("Here is the total expressed in the following currencies...");
            Console.WriteLine("US: $" + string.Format("{0:0.00}", Total));
            Console.WriteLine("Swedish: " + string.Format("{0:0.00}", Total) + " kr");
            Console.WriteLine("Japanese: " + Math.Round(Total) + " Yen");
            Console.WriteLine("Thai: " + string.Format("{0:0.00}", Total) + " Thai Baht");
        }
    }
}
