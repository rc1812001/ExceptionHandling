using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        //NOTE:  DIVIDE METHOD FROM DivideByZeroException Class is called  here (i.e in Program.cs)
        
        static void Main(string[] args)
        {
            Division division = new Division();
            division.Divide(35, 0);
            Console.ReadLine();
        }
        
    }
}
