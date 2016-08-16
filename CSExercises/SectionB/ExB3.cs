using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSExercises
{
    //The ABC Company pays its employees salary plus benefits.  
    //The benefits are calculated as a percentage of the salary.  
    //The company pays every employee 10% housing allowance and 
    //3% transport allowance.  Write a program that takes the salary 
    //as input and prints the total income 
    //(salary + housing allowance + transport allowance) as output.  
    //Format the output in currency format.

    public class ExB3
    {
        public static void Main(string[] args)
        {
            String salary = Console.ReadLine();


            
            decimal x = Convert.ToDecimal(salary);
            decimal result = CalculateIncome(x);
            Console.WriteLine(" {0:C}",result);
            
            //YOUR CODE HERE

        }

        public static decimal CalculateIncome(decimal salaryStr)
        {
            
            decimal housing = (salaryStr* 10) / 100;
            decimal transport = (salaryStr * 3) / 100;
            decimal totalincome = salaryStr + housing + transport;

            return totalincome ;

            //YOUR CODE HERE
           
        }
    }
}
