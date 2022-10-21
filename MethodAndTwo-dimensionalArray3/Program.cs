using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndTwo_dimensionalArray3
{
    internal class Program
    {
        static void Zapoln(int[,] mas) // заполнение массива рандомными значениями 
        {
            Random r = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        mas[i, j] = r.Next(1, 100);
                    }
                }

            }
        }
        static void post(int[,] mas) // метод позволяющий вывести матрицу с перебором значением 
        {
            foreach (int i in mas)
            {
                Console.WriteLine($"Элемент масства = {i} ");
            }
        }
        static void summa(int[,] mas)
        {
            int sum = 0;
            int countEvenEl = 0,
                countNegativeEl = 0,
                countPositiveEl = 0,
                countAliquantEl = 0;
            foreach (int i in mas) // цикл для проверки каждого элемента в массиве
            {
                sum += i; // считаем сумму
                if (i > 0) // если i > 0
                    countPositiveEl++; // считаем количество положительных элементов в массиве
                else // иначе
                    countNegativeEl++; // считаем количество отрицательных элементов в массиве

                if (i % 2 == 0) // если i четное
                    countEvenEl++; // считаем количество четных элементов в массиве

                if (i % 3 == 0) // если i кратно трем
                    countAliquantEl++; // считаем количество элементов кратных трем
            }

            Console.WriteLine($"Сумма элементов одномерного массива: {sum}");
            Console.WriteLine($"Количество отрицательных элементов: {countNegativeEl}");
            Console.WriteLine($"Количество положительных элементов: {countPositiveEl}");
            Console.WriteLine($"Количество четных элементов: {countEvenEl}");
            Console.WriteLine($"Количество элементов, не кратных трем: {countAliquantEl}");

        }


        static void Main(string[] args)
        {
            int[,] mss = new int[3, 3];
            Zapoln(mss);
            post(mss);
            summa(mss);

        }
    }
}


