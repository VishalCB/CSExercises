using System;

namespace CSExercises
{
    //Electrifying Electronics Pte Ltd. manufactures 
    //three audio-visual electronic products named 
    //as TV, DVD, and MP3.  The table below gives 
    //the unit price for each of these products:

    //PRODUCT   PRICE
    //TV	    $900
    //DVD	    $500
    //MP3	    $700

    //Retailers make orders for these products. 
    //Each order will have the product code and quantity 
    //(only one product in an order).  The company has a policy 
    //that discount of 10% is given when the order amount exceeds 
    //$5000 and 15% discount when the order amount exceeds $10000.  
    //These discounts apply to TV and DVD only and no discount is provided for MP3.

    //Write a program that would prompt the user successively 
    //the three product codes viz., TV, DVD, MP3 and after each prompt, 
    //the user enters the order quantity for that product.  
    //Then apply the price computations.  (Obviously, if the user does not 
    //wish to order the item prompted he/she would enter a zero for the order quantity).

    public class ExC6
    {
        public static void Main(string[] args)
        {


            Console.WriteLine("Enter the number of tv you want");
            String x= Console.ReadLine();
             int tvqty = Convert.ToInt32(x);

            Console.WriteLine("Enter the number of dvd you want");
            String y = Console.ReadLine();
            int dvdqty = Convert.ToInt32(y);

            Console.WriteLine("Enter the number of mp3 you want");
            String z = Console.ReadLine();
            int mp3qty= Convert.ToInt32(z);

            double result = CalculateTotalPrice(tvqty, dvdqty, mp3qty);
            Console.WriteLine(result);

            //YOUR CODE HERE - get user input, call the function and return the discounted price



        }

        public static double CalculateTotalPrice(int tvQty, int dvdQty, int mp3Qty)
        {
            int tv = 900;
            int dvd = 500;
            int mp3 = 700;
          //  int tot = (tvQty * tv) + (dvdQty * dvd) + (mp3Qty * mp3);
            int tot1 = (tvQty * tv) + (dvdQty * dvd);
            int disc=0;
           // int total=0;
           
            if(tot1 >=5000 && tot1 <=10000)
            {



                disc=(tot1 * 10) / 100;
                

            }
            else if(tot1 > 10000)
            {

                disc = (tot1 * 15) / 100;
                
                
                


            }
           int  total = (tot1 - disc) + (mp3* mp3Qty);
            //YOUR CODE HERE
            return total;



        }
    }
}