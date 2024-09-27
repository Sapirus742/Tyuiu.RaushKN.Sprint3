using Tyuiu.RaushKN.Sprint3.Task1.V11.Lib;

namespace Tyuiu.RaushKN.Sprint3.Task1.V11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #3                                                               #");
            Console.WriteLine("# Тема: Оператор цикла while                                              #");
            Console.WriteLine("# Задание #1                                                              #");
            Console.WriteLine("# Вариант #11                                                             #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Написать программу используя цикл while, которая вычисляет произведение #");
            Console.WriteLine("# ряда по формуле, при a=0,75                                             #");
            Console.WriteLine("#                                                                         #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            double value = 0.75;
            int startValue = 1;
            int stopValue = 14;

            Console.WriteLine("Переменная n: " + value);
            Console.WriteLine("Старт шага: " + startValue);
            Console.WriteLine("Конец шага: " + stopValue);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Произведение ряда: " + ds.GetMultiplySeries(value, startValue, stopValue));
            Console.ReadKey();
        }
    }
}
