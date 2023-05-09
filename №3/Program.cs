using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application
        //Создайте программу в которой создайте целочисленную последовательность
        //размерностью 30 элементов(последовательность заполнить случайными числами),
        //содержащая как положительные, так и отрицательные числа.Вывести ее первый
        //положительный элемент и последний отрицательный элемент.
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list1 = new List<int>();
            for (int i = 0; i < 30; i++){
                int result = random.Next(-20, 20);
                list1.Add(result);   
            }
            var positiveElement = list1.Where(i => i >= 0);
            var negetiveElement = list1.Where(i => i < 0);
            var Fisrt = positiveElement.First();
            var Second = negetiveElement.Last();
            Console.WriteLine("Первый положительный элемент: " + Fisrt);
            Console.WriteLine("Последний отрицательный элемент: " + Second);
        }
    }
}
