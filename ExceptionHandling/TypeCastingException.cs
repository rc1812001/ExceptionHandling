
using System;

namespace MyApplication
{
    class Hello
    {
        
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter number1:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter number2:");
                int num2 = Convert.ToInt32(Console.ReadLine());

                int sum = num1 + num2;
                Console.WriteLine("Sum" + sum); //returns Sum of num1 and num2
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        

    }
}

