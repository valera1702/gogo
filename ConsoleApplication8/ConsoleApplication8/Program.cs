using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    public class Program
    {


       public static double[] BubbleSort(double [] mas)
        {
            double temp; int k = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                        k++;
                    }
                }
            }
            Console.WriteLine("Колличество операций "+k);
            return mas;
        }


        static void Main(string[] args)
        {
          
            Random rand = new Random();
             
            double[] array = new double[100];

            double[] array1 = { 1.2, 1.3, 1.5, 1.6, 1.7};

            double[] array2 = { 1.7, 1.6, 1.5, 1.3, 1.2};

            for (int i=0; i<array.Length; i++)
            {
                array[i] = Math.Round(rand.Next(100) / 3.1 , 3);
               
            }

            array = BubbleSort(array);
            Console.WriteLine("Сортировка пузырьком");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }


            Console.ReadKey();
        }
    }
}
