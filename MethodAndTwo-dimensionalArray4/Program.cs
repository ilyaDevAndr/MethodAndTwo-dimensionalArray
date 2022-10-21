using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndTwo_dimensionalArray4
{
    internal class Program
    {
        static void Rand(int[,] mas)
        {
            Random r = new Random();
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(1); j++)
                {
                    mas[i, j] = r.Next(20, 50);
                }
            }
        }
        static int srednee(int[,] mas)
        {
            int sum = 0;
            foreach (int result in mas)
            {
                sum += result;
            }
            return sum;
        }
        static void post(int[,] mas)
        {
            foreach (int k in mas)
            {
                Console.WriteLine($"Элемент = {k}");

            }
        }

        static void Main()
        {
            Console.WriteLine("Козырский Илья 24ис");
            int[,] bbb = new int[3, 3];
            Rand(bbb);

            post(bbb);
            Console.Write("Сумма элементов массива ");
            Console.WriteLine(srednee(bbb));
            Console.ReadKey();

        }
    }
}


