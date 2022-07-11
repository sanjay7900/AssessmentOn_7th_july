using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSESSMENT_1
{
    public class Computation:IAddition,IMultiplication
    {
       public  void  Addsum()
       {
            Console.WriteLine("Enter the first number");
            int a= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int b= Convert.ToInt32(Console.ReadLine()); 
            int c= a+b;
            Console.WriteLine($" Sum : {c} ");

       }
        public  void product()
        {
            Console.WriteLine("Enter the first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a * b;
            Console.WriteLine($" Pruduct : {c} ");

        }
        
    }
}
