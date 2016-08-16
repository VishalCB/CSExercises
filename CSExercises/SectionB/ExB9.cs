﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //In the ABC Taxi Company problem above, 
    //calculate the fare so that the fare is always 
    //rounded upwards to the nearest 10 cents. 
    //This is harder than the previous problem 
    //and requires your ingenuity

    public class ExB9
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
            double fare = 2.40 + (distance * 0.40);
            //YOUR CODE HERE
            double roundval = Math.Pow(10, 1);

            double fare1 = Math.Ceiling(fare * roundval) / roundval;
            return fare1;

        }
    }
}
