using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeloWorldDemo171Batch
{
    public class Human
    {
        //state(characterstics) of human
        public string name; //instance
        public float height;

        public Human()
        {
            Console.WriteLine("default constructor");
        }
        //public Human(string humanName, float humanHeight)
        //{
        //    name=humanName;
        //    height = humanHeight;
        //}

        public static void Walk()
        {
            //Console.WriteLine(humanName);
            Console.WriteLine("human can walk");
        }

        public void HumanDetails()
        {

            Console.WriteLine("name:{0} height:{1}",name,height);
        }

    }
}
