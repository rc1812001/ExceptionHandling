using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class InsufficientMemory
    {
        static void Main(string[] args)
        {

            StringBuilder stringBuilder = new StringBuilder(17, 17); //Max size of Obj of StringBuilder is given here
            stringBuilder.Append("Welcome to the ");
            try
            {
                stringBuilder.Insert(0, "world of C# programming", 1); //Adding more characters to it will throw an exception of insufficient memory
                Console.WriteLine(stringBuilder.ToString());
                Console.ReadLine();
            }
            catch (OutOfMemoryException exception)
            {
                Console.WriteLine(exception.Message);
                Console.ReadLine();
            }

        }
    }
}

    

