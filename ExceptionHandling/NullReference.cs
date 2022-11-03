using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class NullReference
    {

        class Demo
        {
            
            static void Main()
            {
                try
                {
                    string str = null; // null value is assigned to string

                    if (str.Length > 0) //an exception occurs here {Null Reference}
                    {
                        Console.WriteLine(str);
                    }
                }
                catch (Exception NullReference)
                {
                    Console.WriteLine(NullReference.Message);
                }
            }
            
        }
    }
}
