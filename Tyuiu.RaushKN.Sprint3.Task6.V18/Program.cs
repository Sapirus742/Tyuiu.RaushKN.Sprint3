using Tyuiu.RaushKN.Sprint3.Task6.V18.Lib;

namespace Tyuiu.RaushKN.Sprint3.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #3                                                               #");
            Console.WriteLine("# Тема: Обработка целочисленной информации                                #");
            Console.WriteLine("# Задание #6                                                              #");
            Console.WriteLine("# Вариант #18                                                             #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Напишите программу, которая ищет среди целых чисел, принадлежащих       #");
            Console.WriteLine("# числовому отрезку [9, 18] сумму всех делителей меньше 10                #");
            Console.WriteLine("#                                                                         #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            int startValue = 9;
            int stopValue = 18;


            Console.WriteLine("Начало числового отрезка = " + startValue);
            Console.WriteLine("Конец числового отрезка = " + stopValue);


            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");

            Console.WriteLine("Сумма делителей = " + ds.GetSumTheDivisors(startValue,stopValue));
            Console.ReadKey();
        }
    }
}
