using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class StackOverFlowException
    {
        public class check
        {
            // a method called ex is defined which takes a value as parameter and increases its value by one
            static void ex(int equals)
            {
                Console.WriteLine(equals);
                ex(++equals);
            }
            //main method is called within which try and block methods are defined to catch the exception
            public static void Main()
            {
                try
                {
                    //The ex method is called by passing zero as a parameter to start the infinite recursion
                    ex(0);
                }
                catch (StackOverflowException ep)
                {
                    Console.WriteLine(ep.Message);
                }
            }
        }
      
    }
}
