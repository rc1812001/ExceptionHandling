using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    
    internal class IndexOutOfRange
    {
        static void Main(string[] args)
        {
            try
            {

                int[] Numbers = {1,2,3,4,5,6};

                for (int i = 0; i < Numbers.Length; i++)
                {
                    Console.WriteLine(Numbers[i]);//Print elements of Numbers Array
                }

                Console.WriteLine(Numbers[9]);//Exception: Index out of Range because size of Array is 6
            }
            catch (Exception IndexOutOfRangeException)
            {
                Console.WriteLine(IndexOutOfRangeException.Message);//Display Message
            }

            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
            Console.ReadLine();

        }
    }
    
}
 