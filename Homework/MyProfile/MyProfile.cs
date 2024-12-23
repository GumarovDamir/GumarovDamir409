using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework.MyProfile
{
    record BirthInfo(DateTime BirthDate);

    class Human
    {
        public string? Name, Surname, Hobbies, Information;

        public required BirthInfo Birth { get; init; }

        public int Age
        {
            get
            {
                DateTime currentDate = DateTime.Now;
                DateTime birthDate = Birth.BirthDate;
                int age = currentDate.Year - Birth.BirthDate.Year;

                if (currentDate < Birth.BirthDate.AddYears(age))
                {
                    age--;
                }

                return age;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human
            {
                Birth = new BirthInfo(new DateTime(2005, 09, 02)),
            };
            h.Name = "Дамир";
            h.Surname = "Гумаров";
            h.Hobbies = "музыка, рисование, игры";
            h.Information = "родился в Казахстане, прожил в городе Актобе 18 лет, есть 1 кошка и 1 кот";

            Console.WriteLine("Имя: {0}\nФамилия: {1}\nВозраст: {2}\nХобби: {3}\nДополнительно: {4}", h.Name, h.Surname, h.Age, h.Hobbies, h.Information);
        }
    }
}
