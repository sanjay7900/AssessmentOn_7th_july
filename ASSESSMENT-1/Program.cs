namespace ASSESSMENT_1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Assignment assignment=new Assignment();
            Console.WriteLine("Even odd in list");
            assignment.EvenOdd();
            Console.WriteLine("=======largest number==============");
            Console.WriteLine();

            assignment.LargestNumber(325, 750, 478);
            Console.WriteLine("---------------Boxing unboxing");
            Console.WriteLine();
            assignment.Boxing();
            Console.WriteLine("============All odd number in limit 10");
            assignment.FindEvenOddInlimit(10);
            Console.WriteLine("===========Shorting===================");

            assignment.SortingCities();
            Console.WriteLine("=========Method Overloading===========");
            assignment.sum(20, 20);
            assignment.sum(10, 10, 10);
            assignment.sum(20, 25.5);
            assignment.sum(25.5, 25.5);
            Console.WriteLine();
            assignment.GenericCricketerDictionary();
            Console.WriteLine();
            assignment.StudentGenericList();
            Console.WriteLine();
            Console.WriteLine();
            


            Console.WriteLine("----------------- Interface---------------");
            Computation computation=new Computation();
            computation.Addsum();
            Console.WriteLine();
            computation.product();
            Console.WriteLine();

            Console.WriteLine("================== Constructor Overloading===============");
            ConstructorOverloding constructorOverloding = new ConstructorOverloding(20);
            ConstructorOverloding constructorOverloding1 =new ConstructorOverloding(2,3);
            ConstructorOverloding constructorOverloding2 =new ConstructorOverloding(3,4,9);



            Console.ReadKey();

        }
    }

}

