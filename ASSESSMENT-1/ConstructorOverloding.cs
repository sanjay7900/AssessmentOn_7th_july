using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSESSMENT_1
{
    public class ConstructorOverloding
    {
        public ConstructorOverloding(int a,int b)
        {
            Console.WriteLine(" I have Two Parameter : constructor overloading");
        }
        public ConstructorOverloding(int a, int c,int d)
        {
            Console.WriteLine("I have 3 Parameter : constructor overloading")
                ;
        }
        public ConstructorOverloding(int a)
        {
            Console.WriteLine("I have Only 1 Parametter :constructor Overloading");
        }

    }
}
