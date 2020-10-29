using System;
using System.Runtime.CompilerServices;

namespace Assessment1A
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //bool IsPassing = (true, false) ;
            Console.WriteLine();
            //double grade = 0; 
        }

        public  static bool  IsPassing( double grade)
        { 
            

            if (grade <= 65)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        static int AverageGrades( int grade1, int grade2, int grade3)
        {
            int totaL = grade1 + grade2 + grade3;
            return totaL;
        }

        public static int OddOrEvenAndPassing(double grade)
        {
            if (grade % 2 != 0 && grade > 60)
            {
               Console.WriteLine ("Passing and Odd");
            }
            else if (grade % 2 != 0 && grade < 60 )
            {
                Console.WriteLine("failing and Odd");
            }
            else if (grade % 2 == 0 && grade > 60)
            {
                Console.WriteLine("Passing and Even");
            }
            else if (grade % 2 == 0 && grade > 60)
            {
                Console.WriteLine("Failing and even");
            }
            else
            {
                Console.WriteLine("This is not a grade");
            }


        }



    }
}
