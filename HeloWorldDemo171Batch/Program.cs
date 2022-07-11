using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeloWorldDemo171Batch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to 171Batch");
            Console.WriteLine("Please choose number between 1 to 3 as shown below\n1:Human Program\n2:Reverse Program.\n3:Pholyndrome program.");
            int option = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("After Update");
            //Console.WriteLine("Introducing newlines of code from developer2 ");
            //Console.WriteLine("Modifying in local repository");
            //Console.WriteLine("Changes from remote master");

            switch (option)
            {
                case 1:
                    // code block
                    Human kavitha = new Human();
                    kavitha.HumanDetails();
                    Human harish = new Human();
                    harish.HumanDetails();
                    Human.Walk();
                    break;
                case 2:
                    // code block
                    Console.WriteLine("Please enter 4digit number"); //1234
                    //converting from string into integer datatype
                    int number = Convert.ToInt32(Console.ReadLine()); //"1234"
                    ReverseNumber.MakeItReverse(number);
                    ReverseNumber.SimpleWhileLoop();
                    break;
                default:
                    // code block
                    Pholyndrome.FindPholydrome();
                    break;
            }           
            Console.ReadLine();
        }
    }
}
