using System;

namespace CSExercises
{
    public class ExB10
    {
        //Consider the simple Geometric example of determining 
        //the area of a triangle, given the lengths of 
        //    its three sides a, b and c.
        //
        //Use the formula:  AREA = SQUAREROOT[s(s - a)(s - b)(s - c)]
        //                     where s = (a+b+c) / 2
        //
        //Does your program always work? If not 
        //alter it to consider situations fro which 
        //it fails.You can return a special value like -1 to 
        //indicate that you cannot calculate the area.

            
        
        public static void Main(string[] args)
        {
            
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());

            double result = CalculateArea(a, b, c);
            Console.WriteLine(result);
        
            //YOUR CODE HERE

        }

        public static double CalculateArea(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s*(s - a)*(s - b)*(s - c));
            //YOUR CODE HERE
            return area;
        }
    }
}