using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер задачи 1-4");
            int caseSwitch = Convert.ToInt32(Console.ReadLine());

            switch (caseSwitch)
            {
                case 1:
                    double n = 23.16809;
                    n = Math.Round(n - Math.Truncate(n), 3) * 1000;
                    string str = Convert.ToString(n);
                    n = 0;
                    for (int i = 0; i < str.Length; i++)
                    {
                        n += double.Parse(str[i].ToString());

                    }
                    Console.WriteLine(n);
                    break;
                case 2:
                    Console.WriteLine("Вычисление стоимости поездки на дачу.");
                    Console.WriteLine("Расстояние до дачи (км) ");
                    double s = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("количество бензина, которое потребляет автомобиль на 100 км пробега;");
                    double benz = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("цена одного литра бензина");
                    double cena = Convert.ToDouble(Console.ReadLine());
                    double rub = Math.Truncate((s / 100 * benz * cena) * 2);
                    double kop = ((s / 100 * benz * cena) * 2 - rub);
                    kop = Math.Round(kop, 2);
                    Console.WriteLine("Поездка на дачу обойдется в " + rub + " руб " + kop * 100 + " коп");
                    break;
                case 4:
                    double chislo = 12.348;
                    double n1 = Math.Round(chislo - Math.Truncate(chislo), 2) * 100;
                    Console.WriteLine(Math.Truncate(chislo) + " руб " + n1 + " коп");
                    break;
                case 3:
                    Console.WriteLine("Введите а");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите b");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите c");
                    int c = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите m");
                    int m = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите N");
                    int N = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите d");
                    int d = Convert.ToInt32(Console.ReadLine());


                    if (a * d * d + b * d + c == 0 && m * d + N == 0)
                    {
                        Console.WriteLine("True");
                    }
                    else
                        Console.WriteLine("False");
                    break;
                default:
                    Console.WriteLine("Задача была выбрана неправильно");
                    break;

            }
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
