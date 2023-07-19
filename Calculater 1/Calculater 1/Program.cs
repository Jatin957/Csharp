using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            int result;

            string answer; 

            Console.WriteLine("Calculator ");
            Console.WriteLine("Enter your First Number");

            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Second Number");

            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type of opretions");
            Console.WriteLine("'a' for addition, 's' for substraction, 'm' for multiplication, 'd' for division");

            answer = Console.ReadLine();


            if (answer == "a")
            {
                result = num1 + num2;
                
            }
            else if (answer == "s")
            {
                result = num1 - num2;
                
            }
            else if (answer == "m")
            {
                result = num1 * num2;
                
            }
            else
            {
                result = num1 / num2;
                 
            }

            Console.WriteLine("Your answer :"+ result);
            Console.ReadKey();
            
            

        }
    }
}
