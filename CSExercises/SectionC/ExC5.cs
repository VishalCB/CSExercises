using System;

namespace CSExercises
{
    //Given a three-digit integer as input write a C# program 
    //to determine whether the number is an Armstrong number.
    //
    //An Armstrong number is one for which the sum of each digit 
    //raised to the power of number of digits results in the number itself.
    //
    //For a three digit number 153 =  13 + 53 + 33  
    //
    //Confine the input to 3 digit examples only ie., number values 100…999.


    public class ExC5
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("PLEASE ENTER ONLY 3 DIGIT NUMBER");

            int n = int.Parse(Console.ReadLine());

            bool result = IsArmstrongNumber(n);
            //YOUR CODE HERE
            Console.WriteLine(result);
        }


        public static bool IsArmstrongNumber(int n)
        {
            int temp = n%10;

            int x = temp * temp * temp;

            int temp1 = n / 10;

            int temp2 = temp1 % 10;

            int y = temp2 * temp2 * temp2;

            int temp3 = temp1 / 10;

            int z = temp3 * temp3 * temp3;

            int final = x + y + z;

            if (final == n)
            {
                return true;
            }
            else
            {
                //YOUR CODE HERE
                return false;
            }

        }
    }
}