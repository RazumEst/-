using System;

namespace Библиотеки_
{
    internal class Program
    {
        //рефакторинг кода в решении "тестирование".
        //1. создаем метод, который будет выводить массив типа double. Т.к. у квадратного
        //уравнения 2 корня, и я их верну через массив.
        //этот код стал тестируемым в отличие от предыдуще его версии. 

        static double[] Solve(double a, double b, double c)
        {
            var discriminant = b * b - 4 * a * c;
            var x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            var x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            return new[] { x1, x2 };
        }
        //в дальнейшем я уберу метод Solve в библиотеку, т.к. он может понадобиться
        // в других проектах. 
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var result = Solve(a, b, c);

            Console.WriteLine(result[0]);
            Console.WriteLine(result[1]);

        }
    }
}
