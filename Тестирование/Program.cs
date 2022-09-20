using System;

namespace Тестирование_
{
    internal class Program
    {
        //Библиотеки. 
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var b = double.Parse(Console.ReadLine());
            var c = double.Parse(Console.ReadLine());

            var discriminant = b * b - 4 * a * c;
            var x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            var x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            //эту программу тестировать трудно, т.к. в ней смешан ввод из консоли
            // и вычисление. Нужно разделить программу на разные методы, которые будут:
            //1. вводить и выводить информацию.
            //2. производить вычисления. 

        }
    }
}
