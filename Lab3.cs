using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main()
        {
            
            int num, rem;
            Console.WriteLine("Please enter a number between 1 and 100.");

            num = Convert.ToInt32(Console.ReadLine());
            
            try
            {
                rem = num % 2;
                //odd = num / 1;

                if ((rem == 0) && (num < 25))
                {
                    Console.WriteLine("{0} is an even number and less than 25.", num);
                }
                else if ((rem == 1) && (num > 60) && (num <=100))
                {
                    Console.WriteLine("{0} is odd and greater than 60.", num);
                }

                else if ((rem == 1) && (num <= 100))

                {
                    Console.WriteLine("{0} is an odd number", num);
                }

                else if ((rem == 0) && (num >= 60) && (num <= 100))
                {
                    Console.WriteLine("{0} is even and greater than 60.", num);
                }

                else if ((rem == 0) && (num >= 26 && num <= 60))
                {
                    Console.WriteLine("{0} is even and between 26 and 60.", num);
                }
                else if (num > 100)
                {
                    Console.WriteLine("The number you entered is: " + (num) + " but needs to be between 1 and 100!!");
                }
                else
                {
                    Console.WriteLine("Please enter positive numbers.");
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                Console.ReadKey();
                
            }
        }
    }
}


              
            
            
        
        
    

