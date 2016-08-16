using System;

namespace CSExercises
{
    //ABC Taxi Company has the following meter charges based on the kilometres travelled.

    //Minimum charge:  $2.40  (first 0.5 km no additional charges apply)
    //For the next 8.5 kms the rate is 4 cents for every 100 meters
    //After that:   5 cents for evey 100 meters

    //In the above example you should assume that the meter falls every 100 meters.So assume that if the distance travelled(i.e.input) is 12.13 km then it is rounded to 12.20 and the cost would be:

    //$ 2.40 (first 0.5 km) +
    //$ 85 * 0.04 (next 8.5 km) +
    //$ (122 -90) * 0.05 (for distance over 9.0 km)
    //=  $7.40


    public class ExC4
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("KILOMETERS TRAVELLED:");
            double km = double.Parse(Console.ReadLine());

            double distance = CalculateFare(km);
            Console.WriteLine(distance);



            //Your code here



        }

        public static double CalculateFare(double distance1)
        {
            double distance = Math.Ceiling(distance1 * 10) / 10;
  
            double km1 = 2.40;
            double km2 = 0.04;
            double km3 = 0.05;
            double total = 0;
            double temp = 0;
            double temp1 = 0;
            if (distance <= 0.5)
            {
                total = km1;
            }
            else if(distance>0.5 && distance<=9)
            {
                temp = (distance - 0.5)*10;
                total = km1 + temp * km2;
            }
            else if(distance>9)
            {
                temp = (distance - 9)*10;
                temp1 = (9 - 0.5) * 10;
                total = km1 + temp1 * km2 + temp * km3;
            }

            

            //YOUR CODE HERE
            return total;



        }
    }
}