using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class ArrayMismatchExceptio
    {

        
        static void Main()
        {
            try
            {
                // Declares and assigns a string array.
                // ... Then implicitly casts to base class object.
                // ... Then assigns invalid element.
                string[] array1 = { "cat", "dog", "fish" };
                object[] array2 = array1;
                array2[0] = 5;
                // entering an element of int type in a string array
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
    }
}


