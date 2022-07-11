using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASSESSMENT_1
{
    public class Assignment
    {
        public void EvenOdd()
        {
            List<int> number=new List<int>();
            number.Add(-50);
            number.Add(65);
            number.Add(56);
            number.Add(71);
            number.Add(81);
            int even = 0;
            int odd = 0;    
            for (int i = 0; i < number.Count; i++)
            {
                if (number[i] % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine($"Even Count : {even}  And Odd Count : {odd}  ");
        }
        public void LargestNumber(int first,int second,int third)
        {
            int large= first > second ? (first > second ? first : third) : (second > third ? second : third);
            Console.WriteLine(large);

        }
        public void FindEvenOddInlimit(int limit)
        {
            


            for(int i = 1; i <= limit; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("odd number : "+i);

                }
                

            }
            
        }
        public void sum(int a,int b)
        {
            Console.WriteLine($"sum ={a+b}");
        }
        public void sum(int a, int b, int c)
        {
            Console.WriteLine($"sum = {a+b+c} ");
        }
        public void sum(int a, double b)
        {
            double c = a + b;
            Console.WriteLine($"sum = {c}");
        }
        public void sum(double a,double b)
        {
            Console.WriteLine($"sum = {a+b}");
        }
        public void SortingCities()
        {
            List<string> cities = new List<string> { "Delhi", "Mumbai", "Kolkata", "Channai" };
            cities.Sort();
            foreach(string c in cities)
            {
                Console.Write($"{c} , ");
            }


        }
        public void GenericCricketerDictionary()
        {
            Dictionary<int, string> player = new Dictionary<int, string>();
            player.Add(1, " MS Dhoni");
            player.Add(2, "Rhoit sharma");
            player.Add(3, "Virat Kholhi");
            player.Add(4, "Umesh Yadev");
            player.Add(5, "Jasprit Bumrha");
            player.Add(6, "Ravi Chandan Asewin");
            Console.WriteLine();
            foreach(int key in player.Keys)
            {
                Console.Write($" {key} : {player[key]} , ");

            }
        }
        public void StudentGenericList()
        {
            List<Student> students = new List<Student>
            {
                new Student{Id=1,Name="sanjay",Age=21},
                new Student{Id= 2, Name="Rakesh" ,Age=22},
                new Student{Id= 3, Name="raju" ,Age=18},
                new Student{Id= 4, Name="Ramesh" ,Age=14},
                new Student{Id= 5, Name="Robin" ,Age=15},
                new Student{Id= 6, Name="Akash" ,Age=23},
                new Student{Id= 7, Name="Mithun" ,Age=16},
                new Student{Id= 8, Name="rahul" ,Age=17},
                new Student{Id= 9, Name="Krishna" ,Age=19},
                new Student{Id= 9, Name="Sanddep" ,Age=13},

            };   
            var TeenAgers=students.Where(s=>s.Age>=13 && s.Age<=19).ToList();
            Console.WriteLine();
            foreach(Student student in TeenAgers)
            {
                Console.WriteLine($" Name :{student.Name},   Age :{student.Age}");
            }
        }
        public void Boxing()
        {
            int i = 234;
            object o = i;
            //i = 432;
            Console.WriteLine($"i ={i} And Object {o}");
            


        }
        public void Unboxing()
        {
            object o = 679;
            int i =(int) o;
            Console.WriteLine($" i={i} object {o}");
            
        }

    }
}
