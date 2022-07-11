using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeloWorldDemo171Batch
{
    class Fibonocci
    {
        public static void FindSeries(int numOfSeries)//5
        {
            //0 1 
            int n1 = 0, n2 = 1, n3;
            Console.Write(n1+" "+n2);// 0 1 1 2 3
            for (int i = 2; i < numOfSeries; i++)
            {
                n3 = n1 + n2; //3
                Console.Write(" "+n3);//1 2
                // n1=1, n2=1, n3=2;
                n1 = n2; //1
                n2 = n3; //2
            }
        }
    }
}
