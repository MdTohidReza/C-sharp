using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable here x,y,z are the variable which hold value like 20,30,40
            //int x; 
            //int x = 20;
            //int y = 30;
            //int z=40
            //int y;
            //int z;

            //int x, y, z;
            //int x = 10, y = 20, z = 30;




            //Data Types
            //int age = 25;
            //Console.WriteLine(age);
            //Console.WriteLine(int.MaxValue);
            //Console.WriteLine(int.MinValue);

            //long BigNumber = 90000000L;
            //Console.WriteLine(BigNumber);
            //Console.WriteLine(long.MaxValue);
            //Console.WriteLine(long.MinValue);

            //double negative = -55.2D;
            //Console.WriteLine(negative);
            //Console.WriteLine(double.MaxValue);
            //Console.WriteLine(double.MinValue);

            //float precision = 5.000001F;
            //Console.WriteLine(precision);
            //Console.WriteLine(float.MaxValue);
            //Console.WriteLine(float.MinValue);

            //decimal Money = 55.2M;
            //Console.WriteLine(Money);
            //Console.WriteLine(decimal.MaxValue);
            //Console.WriteLine(decimal.MinValue);

            //age = 50; This is called assiging the value

            ////converting string to number
            //string TextAge = "25";
            //int Age = Convert.ToInt32(TextAge);
            //Console.WriteLine(Age);

            ////similarly
            ////Convert.ToInt64();
            ////Convert.ToDouble();
            ////Convert.ToDecimal();
            ////Convert.ToSingle();


            ////TASK:-1 = Storing User Data

            //string name = "Tohid Reza";
            //Console.WriteLine(name);

            //long phoneNumber = +977-9819817114;// this operate as subtraction
            //string phoneNumberText = "+977-9819817114";// always use string for phone Number or 9779819817114
            //Console.WriteLine(phoneNumberText);
            //Console.WriteLine(phoneNumber);

            //int yearOld = 24;
            //Console.WriteLine(yearOld);

            //var names = "Tohid Reza";
            //Console.WriteLine(names);

            //var phoneNumbers = +977-9819817114;
            //Console.WriteLine(phoneNumbers);

            //var yearOlds= 24;
            //Console.WriteLine(yearOlds);

            ////Task:-2 = odd/even checker

            //int num1 = 10;
            //int num2 = 2;
            //int remainder = num1 % num2;
            //Console.WriteLine(remainder);
            //// result is o, so it is even

            //num1 = 11;
            //remainder= num1 % num2;
            //Console.WriteLine(remainder);
            ////result is 1, so it is odd



            //console input/output

            //Console.WriteLine("Hello My Name is Tohid");

            Console.Write("Enter Your Name : ");// instead of writeLine() we are using only write() to print o/p in single line
            String name = Console.ReadLine();
            //Console.WriteLine(name);

            Console.WriteLine();

            Console.Write("Enter Your Age : ");
            //String ageInt = Console.ReadLine();
            //int ages = Convert.ToInt32(ageInt);// or we can also write

            int ages = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(age);

            Console.WriteLine();// the work of this line code is to print while line mean gap

            //Console.Write("Your Name is ");
            //Console.Write(name);

            //Console.Write(" and age is ");
            //Console.Write(age);

            //Instead of this above code we can also write this way
            Console.WriteLine("Your name is " + name + "and age is " + ages);
                







            Console.ReadLine();
        }
    }
}
