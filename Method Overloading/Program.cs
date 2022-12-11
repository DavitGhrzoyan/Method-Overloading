using System;

namespace Method_Overloading
{
    class Program
    {
        /// <summary>
        /// Վերադարձնում է 2 ամբողջ թվերի գումարը
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b)
        {
            return a + b;
        }
        /// <summary>
        /// Վերադարձնում է 3 ամբողջ թվերի գումարը
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static int Sum(int a, int b, int c)
        {
            return a + b + b;
        }
        /// <summary>
        /// Վերադարձնում է երկու կոտորակային թվերի գումարը
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        static double Sum(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            double reult = Sum(2.6, 4.5);

            Console.WriteLine(reult);
        }
    }
}
