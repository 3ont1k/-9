//**************************************************************************
//* Практическая работа № 9                                                *
//* Выполнил: Складаный А.А., группа 2ИСПд                                 *
//* Задание:  составление программ циклической структуры:цикл с параметром *
//**************************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace практическая_работа_номер_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "пр/р номер 9";
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            const int n = 5;
            double [] a = new double[n];
            double index = -1;
            int i = 0;
            int j = 0;
            try
            {
                Console.Write("Доброго времени суток!\nВведите 15 случайных элементов массива: ");
                for( i = 0;i < n;i++) Convert.ToDouble (Console.ReadLine());
                Console.WriteLine("массив отсортирован и заменен, чтобы увидить результат нажмите любую клавишу");
                Console.ReadLine();
                for ( i = 0;i < n;i++)
                {
                    for ( j = 0; j < n - 1 - i; j++)
                    {
                        if (a[j] >= a[j + 1])
                        {
                            double temp = a[j];
                            a[j] = a[j + 1];
                            a[j + 1] = temp;
                        }

                    }
                }
                //double max = a[0];
                //for ( i = 0; i<n;i++)
                //{
                //    if (a[i] %2==0)
                //    {
                //        max = a[i];
                //        index = i;
                //    }
                //}
                for (j = 0; j < n; j++)
                {
                    Console.Write(a[j] + " ");

                }


            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ОШИБКА!\n" +  e.Message);
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.ReadLine();
        }
    }
}
