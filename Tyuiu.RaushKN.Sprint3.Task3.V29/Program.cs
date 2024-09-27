using Tyuiu.RaushKN.Sprint3.Task3.V29.Lib;

namespace Tyuiu.RaushKN.Sprint3.Task3.V29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Рауш К. Н. | АСОиУб-24-1";
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# Спринт #3                                                               #");
            Console.WriteLine("# Тема: Оператор цикла foreach                                            #");
            Console.WriteLine("# Задание #3                                                              #");
            Console.WriteLine("# Вариант #29                                                             #");
            Console.WriteLine("# Выполнил Рауш Кирилл Николавевич | АСОиУб-24-1                          #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# УСЛОВИЕ:                                                                #");
            Console.WriteLine("# Используя цикл foreach удалить из строки все буквы h в строке:          #");
            Console.WriteLine("# chgr vhhtg hnht                                                         #");
            Console.WriteLine("#                                                                         #");
            Console.WriteLine("###########################################################################");
            Console.WriteLine("# ИСХОДНЫЕ ДАННЫЕ:                                                        #");
            Console.WriteLine("###########################################################################");

            string value = "chgr vhhtg hnht";
            char item = 'h';

            Console.WriteLine("Исходная строка = " + value);
            Console.WriteLine("Удаляемый символ = " + item);

            Console.WriteLine("###########################################################################");
            Console.WriteLine("# РЕЗУЛЬТАТ:                                                              #");
            Console.WriteLine("###########################################################################");
        
            Console.WriteLine("Преобразованная строка = " + ds.DeleteCharInString(value, item));
            Console.ReadKey();
        }
    }
}
