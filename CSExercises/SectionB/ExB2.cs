using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //Slight modification to above: Write a program that 
    //takes a double precision number as input and prints 
    //the square root of the number.  
    //The square root should be rounded to 3 decimal places.
    //Input	    Output
    //0	        0.000
    //25	    5
    //3	        1.732
    //300	    17.321

    public class ExB2
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
            else
            {
                Console.WriteLine(String.Format("{0:0.000}", result));
            }
            //YOUR CODE HERE
        }

        public static double SQRT(double num)
        {
            double y = Math.Sqrt(num);
           
            return y;

            //YOUR CODE HERE: return the square root of x and then use String.Format 
            //to format it. The format is similar to WriteLine
            

        }
    }
}
