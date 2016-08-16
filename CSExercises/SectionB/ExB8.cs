using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company example before, 
    //print the output so that the fare is the 
    //output is printed always rounded to nearest 10 cents 
    //and printed to two decimal places.

    public class ExB8
    {
        public static void Main(string[] args)
        {
            String input = Console.ReadLine();
            double km = Convert.ToDouble(input);

            double result = CalculateFare(km);

            Console.WriteLine(String.Format("{0:0.0}", result));
            //YOUR CODE HERE
        }

        public static double CalculateFare(double distance)
        {
            double fare =2.40 + (distance * 0.40);
            //YOUR CODE HERE

            return fare;

        }
    }
}
