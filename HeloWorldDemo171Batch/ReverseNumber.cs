using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeloWorldDemo171Batch
{
    public class ReverseNumber
    {
        //syntax access-modifier|static return-type methodName
        public static int MakeItReverse(int number) //1234
        {
            int remainder = 0, reverse = 0;
            while (number != 0)
            {
                remainder = number % 10; //4 3
                reverse = remainder + (reverse * 10); //3 +40=43
                number = number / 10;
            }
            Console.WriteLine("After reverse:{0}", reverse);
            return reverse;
        }

        public static void SimpleWhileLoop()
        {
            int i = 0;
            while (i < 5)
            {
                Console.Write(i+" ");
                i++;
            }
        }
    }
}
