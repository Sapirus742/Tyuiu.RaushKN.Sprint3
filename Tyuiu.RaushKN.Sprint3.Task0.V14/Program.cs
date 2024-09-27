using Tyuiu.RaushKN.Sprint3.Task0.V14.Lib;

namespace Tyuiu.RaushKN.Sprint3.Task0.V14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #3                                                               #");
            Console.WriteLine("# Тема: Оператор цикла for                                                #");
            Console.WriteLine("# Задание #0                                                              #");
            Console.WriteLine("# Вариант #14                                                             #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Написать программу используя цикл for, которая вычисляет произведение   #");
            Console.WriteLine("# ряда по формуле, при n = 2                                              #");
            Console.WriteLine("#                                                                         #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            int value = 2;
            int startValue = 1;
            int stopValue = 5;

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
