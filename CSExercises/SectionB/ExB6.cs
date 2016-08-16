using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that reads the (x,y) coordinates 
    //of two points.  Compute the distance between the 
    //two points using the formula:

    //  Distance = Square Root of[(x2 – x1 ) 2 + (y2 – y1 ) 2]

    public class ExB6
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double x1 = Convert.ToDouble(input);

            string input1 = Console.ReadLine();
            double y1= Convert.ToDouble(input);

            string input2 = Console.ReadLine();
            double x2 = Convert.ToDouble(input2);

            string input3 = Console.ReadLine();
            double y2 = Convert.ToDouble(input3);

            double result = CalculateDistance(x1,y1,x2,y2);

            Console.WriteLine(result);

            //YOUR CODE HERE
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2)
        {
            double dist = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            //YOUR CODE HERE
            return dist;
        }
    }
}
