using System;

namespace InterviewTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int, int> multiply = (a, b, c) => a * b * c;
            Func<int, int, int, int, int, int> add = (a, b, c, d, e) => a + b + c + d + e;

            bool resultAdd = CurryHelper.Curry(add)(1)(2)(3)(4)(5) == add(1, 2, 3, 4, 5);
            bool resultMultiply = CurryHelper.Curry(multiply)(1)(2)(3) == multiply(1, 2, 3);

            Console.WriteLine(resultAdd);
            Console.WriteLine(resultMultiply);
        }
    }
}
