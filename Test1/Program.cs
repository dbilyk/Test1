using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Test1
{
    class Program
    {
        static int RecursiveMethod(int value, ref int counter)
        {
            counter++;
            if (value >= 10)
            {
                return value;   
            }
            RecursiveMethod(value + 1,ref counter);
        }




        static void Main(string[] args)
        {

            int counter = 0;
            int total = RecursiveMethod(1,ref counter);
            Console.WriteLine(total);
            Console.ReadLine();

        }
    }
}
