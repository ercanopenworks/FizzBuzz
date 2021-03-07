using System;

namespace FizzBuzz
{
    class Program
    {
        static public string Run(int N, int M)
        {

            List<string> sequence = new List<string>();

            for (int i = N; i <= M; i++)
            {

                string res = (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" : (i % 5 == 0) ? "Buzz" :
                           (i % 3 == 0) ? "Fizz" : i.ToString();

                sequence.Add(res);
            }
            return String.Join(",", sequence.ToArray());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please input start from N to M ");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = Convert.ToInt32(Console.ReadLine());

            //for (int i = n; i <= m; i++)
            //{

            //    string res = (i % 3 == 0 && i % 5 == 0) ? "FizzBuzz" : (i % 5 == 0) ? "Buzz" :
            //               (i % 3 == 0) ? "Fizz" : i.ToString();
            //    Console.WriteLine(res);
            //}

            string result = Run(n, m);

            Console.WriteLine(result);
            Console.ReadKey();

        }
    }
}
