using System;

namespace LINQ
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Создайте программу в которой создайте класс Calculator, методы которого принимают
        //аргументы и возвращают значения типа dynamic.
        static void Main(string[] args)
        {
            Console.WriteLine("Каркулятор");
            Console.Write("Введите перове число: ");
            double Number1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            double Number2 = double.Parse(Console.ReadLine());
            Console.Write("Меню - 1)Сложение 2)Вычитание 3)Умножение 4)Деление"+"\nВведите число: ");
            int Function = int.Parse(Console.ReadLine());
            Calculator calculator = new Calculator();
            switch (Function)
            {
                case 1:
                    calculator.Add(Number1, Number2);
                    break;
                case 2:
                    calculator.Minus(Number1, Number2);
                    break;
                case 3:
                    calculator.Multiply(Number1, Number2);
                    break;
                case 4:
                    calculator.Division(Number1, Number2);
                    break;
            }
            Console.ReadKey();
        }
    }
    class Calculator {
        private dynamic result;
        public void Add(double a , double b){
            result = a + b;
            Console.WriteLine(result);
        }
        public void Minus(double a, double b){
            result = a - b;
            Console.WriteLine(result);
        }
        public void Multiply(double a, double b){
            result = a * b;
            Console.WriteLine(result);
        }
        public void Division(double a, double b){
            try
            {
                result = a / b;
                Console.WriteLine(result);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }

}
