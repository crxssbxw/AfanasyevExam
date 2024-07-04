using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using src.Classes;

namespace src
{
    class Program
    {
        static void Main(string[] args)
        {
            //Метод для ввода данных о городе
            void CityInput(City city)
            {
                string localName, localFoundation;
                int localPopulation = 0;
                DateTime dateResult;

                Console.WriteLine("Введите название города: ");
                localName = Console.ReadLine();

                Console.WriteLine("Введите дату основания города (DD.MM.YY): ");

                while (!DateTime.TryParse(localFoundation = Console.ReadLine(), out dateResult))
                {
                    Console.WriteLine("Некорректный ввод!");
                }

                Console.WriteLine("Введите количество жителей в городе: ");

                while (!int.TryParse(Console.ReadLine(), out localPopulation) || localPopulation < 0)
                {
                    Console.WriteLine("Некорректный ввод!");
                }

                city.Name = localName;
                city.Foundation = localFoundation;
                city.Population = localPopulation;
            }

            int listLenght; //Размер массива

            CityControl cityControl = new(); //Объект управляющего класса

            Console.Write("Введите размерность массива: ");

            while (!int.TryParse(Console.ReadLine(), out listLenght) || listLenght <= 0)
            {
                Console.WriteLine("Некорректный ввод!");
            }

            cityControl.Cities = new(listLenght);

            for(int i = 0; i < listLenght; i++)
            {
                City city = new();
                CityInput(city);
                cityControl.Cities.Add(city);
            }

            cityControl.Sort();
            cityControl.Save();
        }
    }
}
