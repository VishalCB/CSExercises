﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that takes a double precision number 
    //as input and prints the square root of the number.

    public class ExB1
    {
        public static void Main(string[] args)
        {
            String input = Console.ReadLine();
            double x = Convert.ToDouble(input);
            double result = SQRT(x);
            if (result % 1 == 0 & result != 0)
            {


                Console.WriteLine(result);
            }
            else {
                Console.WriteLine(String.Format("{0:0.000}",result));
            }
            //YOUR CODE HERE
        }

        public static double SQRT(double num)
        {
            double y = Math.Sqrt(num);
            //YOUR CODE HERE: return the square root of x
            return y;

        }
    }
}
