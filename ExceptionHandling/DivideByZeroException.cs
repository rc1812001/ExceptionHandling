using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Division
    {
        int result;

        public Division()
        {
            result = 0;
        }

        public void Divide(int num1,int num2)
        {
            try
            {
                result = num1/num2;

                Console.WriteLine("Result:" + result);
            }

            catch(Exception dividebyZeroException)
            { 
              
                Console.WriteLine (dividebyZeroException.Message);
            }
            
        }

    }
}
