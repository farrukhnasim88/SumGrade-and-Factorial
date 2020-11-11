using System;
using System.Collections.Generic;

namespace SumGrade
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> a = new List<int>();
            a.Add(59);
            a.Add(50);
            a.Add(87);
            a.Add(23);
            gradingStudents(a);

           // Factorial(8);  // factorial of 4 is 4*3*2*1= 24
             

        }

         public static void  Factorial (int n)
        {
            int r = 1;
            if (n >= 1)
            {
                for (int i = 0; i < n; i++)
                {
                    r *= n - i;
                }

                Console.WriteLine(r);
            }

            else
            {
                Console.WriteLine(" Please enter bigger than zero;");
            }

        }

        public static void gradingStudents(List<int> grades)
        {
            List<int> res = new List<int>();
            int m5 = 0;
            foreach (var item in grades)
            {  
                if (item < 38)
                {
                   // Console.WriteLine(item);
                    res.Add(item);
                }

               else if (item % 5 >= 3 && item >=38)
                {
                    m5 += 5-item % 5 ;
                    m5 += item;
                    
                  //  Console.WriteLine(item);
                    res.Add(m5);
                    m5 = 0;
                }
                else if (item % 5 == 0 || item % 5 < 3 && item > 38)
                {
                    //Console.WriteLine(item);
                    res.Add(item);
                }



            }
            foreach (var item in res)
            {
                Console.WriteLine(item);
            }
        }


            
    }
}
