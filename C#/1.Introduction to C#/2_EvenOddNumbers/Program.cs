using System;

namespace _2_EvenOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int index;
            Console.WriteLine("Enter a Number: ");
            int Num =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Even Numbers: ");

            for(index = 0; index <= Num; index++)
            {
                if (index % 2 == 0)
                {
                    Console.WriteLine(index);
                }
               
            }
            Console.WriteLine("Odd Numbers: ");
            for (index = 0; index <= Num; index++)
            {
                if (index % 2 != 0)
                {
                    Console.WriteLine(index);
                }

            }
        }
    }
}
