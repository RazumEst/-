using Solver;
using System;

namespace Библиотеки_2._0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

           var result = QuadraticEquationsSolver.Solve(a, b, c);


            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);
        }
    }
}
