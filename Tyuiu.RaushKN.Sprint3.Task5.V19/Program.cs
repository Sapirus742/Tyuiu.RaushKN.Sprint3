using Tyuiu.RaushKN.Sprint3.Task5.V19.Lib;

namespace Tyuiu.RaushKN.Sprint3.Task5.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #3                                                               #");
            Console.WriteLine("# Тема: Вложенные циклы                                                   #");
            Console.WriteLine("# Задание #5                                                              #");
            Console.WriteLine("# Вариант #19                                                             #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Найти сумму суммы функции, при x = 2                                    #");
            Console.WriteLine("#                                                                         #");
            Console.WriteLine("#                                                                         #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            int x = 2;
            int startValue1 = -5;
            int stopValue1 = 5;
            int startValue2 = -5;
            int stopValue2 = 5;

            Console.WriteLine("Переменная x = " + x);
            Console.WriteLine("Старт шага1 = " + startValue1);
            Console.WriteLine("Конец шага1 = " + stopValue1);
            Console.WriteLine("Старт шага2 = " + startValue2);
            Console.WriteLine("Конец шага2 = " + stopValue2);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");
        
            Console.WriteLine("Сумма суммы функции = "+ds.GetSumSumSeries(x,startValue1,startValue2,stopValue1,stopValue2));
            Console.ReadKey();
        }
    }
}
