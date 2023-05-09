using System;
using System.Collections.Generic;
using System.Linq;

namespace _2
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application
        //Создайте программу для автостанции, в которой вам необходимо создать простую
        //коллекцию автомобилей со следующими данными: Марка автомобиля, модель, год
        //выпуска, цвет.А также вторую коллекцию с моделью автомобиля, именем покупателя и
        //его номером телефона.Используя простейший LINQ запрос, выведите на экран
        //информацию о покупателе одного из автомобилей и полную характеристику
        //приобретенной ними модели.
        static void Main(string[] args)
        {
            List<Car> CarList = new List<Car>() {
                new Car (){NameCar = "Audi", NameModel = "Q7",YearCar = 2003,NameColor = "Black",IdCar = 1},
                new Car (){NameCar = "Bmw", NameModel = "X5",YearCar = 2014,NameColor = "Grey", IdCar = 2},
                new Car (){NameCar = "Opel", NameModel = "Astra",YearCar = 2001,NameColor = "Blue", IdCar = 3}
            };
            List<People> PeoplesCar = new List<People>(){
                new People(){NamePeopleCar = "Vova",PhoneNumber = "+380673429359",IdPeople = 1},
                new People(){NamePeopleCar = "Vlad",PhoneNumber = "+380683321369",IdPeople = 2},
                new People(){NamePeopleCar = "Vika",PhoneNumber = "+380983120399", IdPeople =3}
            };
            foreach (var item in PeoplesCar)
            {
                Console.WriteLine(item.NamePeopleCar + "\t"+ item.PhoneNumber);
                foreach (var item2 in CarList)
                {
                    if (item.IdPeople == item2.IdCar)
                    {
                        Console.WriteLine(item2.NameCar + "\t" + item2.NameModel + "\t" + item2.YearCar + "\t" + item2.NameColor);
                    }
                }
            }
        }
        
    }
    class Car{
        public string NameCar { get; set; }
        public string NameModel { get; set; }
        public int YearCar { get; set; }
        public string NameColor { get; set; }
        public int IdCar { get; set; }
    }
    class People{
        public string NamePeopleCar { get; set; }
        public string PhoneNumber { get; set; }
        public int IdPeople { get; set; }
    }
}
