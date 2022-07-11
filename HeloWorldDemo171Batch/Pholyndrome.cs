using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeloWorldDemo171Batch
{
    public class Pholyndrome
    {
        public static void FindPholydrome()
        {
            int input, reverse = 0;

            Console.WriteLine("Please enter number for pholydrome");
            input=Convert.ToInt32(Console.ReadLine());
            //syntax- calling static method - className.methodName()
            reverse=ReverseNumber.MakeItReverse(input);

            if(input== reverse)
            {
                Console.WriteLine("Given number is pholydrome");
            }
            else
            {
                Console.WriteLine("Given number is not a pholydrome");
            }
        }
    }
}
