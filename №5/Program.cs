using System;
using System.Collections.Generic;
using System.Linq;

namespace _5
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application
        //Создайте программу, в которой, используя динамические и анонимные типы данных,
        //создайте Англо-Русский словарь на 10 слов и выведите на экран его содержание.
        static void Main(string[] args)
        {
            List<Word> words = new List<Word>() {
                new Word() { WordEng = "Football",WordRus = "Футбол"},
                new Word() { WordEng = "Sneaker",WordRus = "Тапок"},
                new Word() { WordEng = "Bulb",WordRus = "Лампочка"},
                new Word() { WordEng = "Light",WordRus = "Свет"},
                new Word() { WordEng = "painting",WordRus = "Картина"},
                new Word() { WordEng = "Door",WordRus = "Дверь"},
                new Word() { WordEng = "Time",WordRus = "Время"},
                new Word() { WordEng = "Pen",WordRus = "Ручка"},
                new Word() { WordEng = "Book",WordRus = "Книга"},
                new Word() { WordEng = "Cloth",WordRus = "Одежда"}
            };
            Console.WriteLine("Англо-Русский словарь");
            Console.WriteLine("Снизу");
            foreach (var item in words){
                Console.Write($"{item.WordRus}"+"   ");
            }
            Console.Write("\nВведите слово:");
            dynamic Wordm = Console.ReadLine();
            var Check = words.Where(i => i.WordRus == Wordm);
            var Last = Check.Last();
            Console.WriteLine(Last.WordEng + "\t" + Last.WordRus);
        }
    }
    class Word{
        public string WordEng { get; set; }
        public string WordRus { get; set; }

    }
}
