﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Write a program that would take as input the 
    //value of x and calculate & output the value 
    //of y using the formula:
 	// y = 5 x2 – 4 x + 3

    public class ExB5
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double X = Convert.ToDouble(input);

            double result = CalculateY(X);
            Console.WriteLine(result);
            //YOUR CODE HERE
        }
        
        public static double CalculateY(double x)
        {


            double Y = (5 * x * x - 4 * x+ 3);
            //YOUR CODE HERE
            return Y;
        }
    }
}
