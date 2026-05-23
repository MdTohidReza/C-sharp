using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace control_flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Name : ");
            string Name = Console.ReadLine();

            Console.Write("Enter your age : ");
            string age = Console.ReadLine();
            int Age = Convert.ToInt32(age);

            Console.WriteLine();

            Console.WriteLine("Your Name is " + Name + "  and Age is " + Age);

            if (Age > 18 && Age < 35)// && is used to check multiple conditions and it returns true if both conditions are true
            {
                Console.WriteLine("You are eligible for vote");
            }
            else if (Age < 18)
            {
                Console.WriteLine("You are not eligible for vote");
            }


            if (Age > 0 || Age < 35) // || is used to check multiple conditions and it returns true if at least one condition is true
            {
                Console.WriteLine("You age is invalid");
            }
            else if (Age < 18)
            {
                if (Age > 18 && Age < 35)
                {
                    Console.WriteLine("You are eligible for vote");
                }
                else if (Age < 18)
                {
                    Console.WriteLine("You are not eligible for vote");
                }
            }


            Console.Write("Enter a First number : ");
            string num1 = Console.ReadLine();
            int Num1 = Convert.ToInt32(num1);

            Console.Write("Enter a Second number : ");
            string num2 = Console.ReadLine();
            int Num2 = Convert.ToInt32(num2);

            int Answer1 = Num1 * Num2;

            Console.Write("Value of "+ Num1 + " X " +Num2 +" : ");
            string ActualAnswer = Console.ReadLine();
            int ActualAnswer2 = Convert.ToInt32(ActualAnswer);

            if(Answer1 == ActualAnswer2)
            {
                Console.WriteLine("Your answer is correct");
            }
            else
            {
                Console.WriteLine("Your answer is incorrect");
            }

            Console.ReadLine();

        }
    }
}
