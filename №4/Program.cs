using System;
using System.Collections.Generic;
using System.Linq;

namespace _4
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application
        //Создайте программу в которой создайте последовательность, которая содержит
        //сведения о клиентах фитнес-центра.Каждый элемент последовательности включает
        //следующие целочисленные поля: «Код клиента», «Год», «Номер месяца»,
        //«Продолжительность занятий(в часах)». Найти элемент последовательности с
        //минимальной продолжительностью занятий.Вывести эту продолжительность, а также
        //соответствующие ей год и номер месяца(в указанном порядке на той же строке). Если
        //имеется несколько элементов с минимальной продолжительностью, то вывести данные
        //того из них, который является последним в исходной последовательности.
        static void Main(string[] args)
        {
            List<People> SportPeople = new List<People>() {
                new People() {CodClient = "123", Year = "2001", NumberMonth = "1", LessonDuration = 1},
                new People() {CodClient = "455", Year = "2003", NumberMonth = "2", LessonDuration = 1},
                new People() {CodClient = "664", Year = "2000", NumberMonth = "5", LessonDuration = 3},
                new People() {CodClient = "555", Year = "2002", NumberMonth = "3", LessonDuration = 8},
                new People() {CodClient = "789", Year = "2007", NumberMonth = "6", LessonDuration = 3},
            };
            var Minimal = SportPeople.Where(i => i.LessonDuration == 1);
            var Last = Minimal.Last();
            Console.WriteLine(Last.CodClient + "\t"+ Last.Year + "\t" + Last.NumberMonth + "\t" + Last.LessonDuration);
        }
    }
}
    class People {
        public string CodClient { get; set; }
        public string Year { get; set; }
        public string NumberMonth { get; set; }
        public int LessonDuration { get; set; }
    }
