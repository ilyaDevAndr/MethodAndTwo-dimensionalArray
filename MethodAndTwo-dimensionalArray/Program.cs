using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAndTwo_dimensionalArray
{
    internal class Program
    {
        static void Rand(int[,] mas) // метод позволяющий заполнить массив рандомными значениями
        {
            Random r = new Random(); // объявление переменной
            for (int i = 0; i < mas.GetLength(0); i++) // строкам
            {
                for (int j = 0; j < mas.GetLength(1); j++) // по столбцам
                {
                    mas[i, j] = r.Next(-40, 30); // Диапозон значиений 
                }
            }
        }
        static void print(int[,] mas) // метод, выводящий массив на экран в виде матрицы
        {
            foreach (int i in mas)
            {
                Console.WriteLine($" Элемент = {i} ");
            }
        }
        static int perechis(int[,] mas)
        {
            int zadan = 0;
            foreach (var result in mas) // с помощью цикла мы узнаем:Кличество элементов массива которые меньше 20, но больше 30 и их элементы 
            {
                if (result > -30 && result < 20) // условие 
                {

                    zadan++;// количество 

                    Console.Write(result + " "); // вывод значений попавших в диапозое



                }
            }
            return zadan;
        }

        static void Main()
        {
            Console.WriteLine("Козырский Илья 24ис");
            int[,] mas = new int[3, 3]; // объявление массива
            Rand(mas);
            print(mas);
            Console.Write($" элементов массива больше -30 , но меньше 20 = ");
            Console.WriteLine("Количество = " + perechis(mas));
            Console.ReadKey();


        }
    }
}


