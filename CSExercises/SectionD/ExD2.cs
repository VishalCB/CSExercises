using System;

namespace CSExercises
{
    //Use Euclid's Algorithm given below to determine 
    //the LCM and HCF for given two integer numbers.

    //- Take in as input two numbers A and B.
    
    //-	Subtract the smaller of the two numbers from 
    //  the Larger Number and assign the answer to the larger number.

    //-	The above process is repeated until both the numbers are equal, say X.
    //-	Apparently the residual number (X) that we have obtained is the HCF.

    //-	LCM could then be computed using the formula(A* B)/HCF

    //-	Print out your answers.


    public class ExD2
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter value A");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter value B");
            int b = int.Parse(Console.ReadLine());
            int temp1 = a;
            int temp2 = b;
            
           do
            {
                
                if (temp1> temp2)
                {
                    temp1 = temp1 - temp2;
                }
                else
                {
                    temp2 = temp2- temp1;
                } 
            } while (temp1 != temp2) ;
            Console.WriteLine("HCF is {0}",temp1);
            int lcm = (a * b) / temp1;
            Console.WriteLine("LCM is {0}", lcm);
            



        }

       
    }
}
