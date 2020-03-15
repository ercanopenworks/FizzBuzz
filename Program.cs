using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 25;

            //for (int i = 1; i <= n; i++)
            //{
            //    if ((i % 3 == 0) && (i % 5 == 0))
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (i % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (i % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else Console.WriteLine(i.ToString());
            //}

            for (int i = 1; i <= n; i++)
            {

                string res = (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" : (i % 5 == 0) ? "Buzz" :
                           (i % 3 == 0) ? "Fizz" : i.ToString();
                Console.WriteLine(res);
            }
            Console.ReadKey();
        }
    }
}
