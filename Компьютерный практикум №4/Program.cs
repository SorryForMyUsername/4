using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Компьютерный_практикум__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Console.Write("Введите целое число: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0)
            //{
            //    ++number;
            //}
            //else
            //{
            //    number -= 2;
            //}
            //Console.WriteLine(number);

            //Task 2
            //Console.Write("Введите целое число: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0)
            //{
            //    ++number;
            //}
            //Console.WriteLine(number);

            //Task 3
            //Console.Write("Введите целое число: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0)
            //{
            //    ++number;
            //}
            //else if (number < 0)
            //{
            //    number -= 2;
            //}
            //else
            //{
            //    number = 10;
            //}
            //Console.WriteLine(number);

            //Task 4
            //Console.Write("Введите целое число: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number % 2 == 0)
            //{
            //    Console.WriteLine($"Число {number} - чётное");
            //}
            //else
            //{
            //    Console.WriteLine($"Число {number} - нечётное");
            //}

            //Task 5
            //Console.Write("Введите целое число: ");
            //int number = int.Parse(Console.ReadLine());
            //if (number > 0)
            //{
            //    Console.WriteLine($"Число {number} - положительное");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine($"Число {number} - отрицательное");
            //}
            //else
            //{
            //    Console.WriteLine($"Число {number} - нулевое");
            //}

            //Task 6
            //Console.Write("Введите цену ноутбука: ");
            //int price = Convert.ToInt32(Console.ReadLine());
            //if (price >= 20000 && price <= 30000)
            //{
            //    Console.WriteLine("Цена ноутбука входит в диапазон от 20 до 30 тыс. рублей.");
            //}
            //else
            //{
            //    Console.WriteLine("Цена ноутбука не входит в диапазон от 20 до 30 тыс. рублей.");
            //}

            //Task 7
            //Console.Write("Введите текущий год: ");
            //int year = Convert.ToInt32(Console.ReadLine());
            //if (year % 4 == 0)
            //{
            //    Console.WriteLine("Текущий год является высокосным");
            //}
            //else
            //{
            //    Console.WriteLine("Текущий год не является высокосным");
            //}

            //int x = 3;
            //int y = 2;

            //int z = x < y ? (x + y) : (x - y);
            //Console.WriteLine(z);   // 1

            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //int y;
            ////if (x > 0)
            ////{
            ////    y = x + 1;
            ////}
            ////else
            ////{
            ////    y = x - 1;
            ////}
            //y = x > 0 ? x + 1 : x - 1;
            //Console.WriteLine(y);

            //Console.Write("x = ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("y = ");
            //int y = int.Parse(Console.ReadLine());
            //int max = x > y ? x : y;
            //Console.WriteLine(max);

            Console.Write("x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("y = ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("z = ");
            int z = int.Parse(Console.ReadLine());
            int max = x > y && x > z ? x : (y > z ? y : z);
            Console.WriteLine(max);

            Console.ReadKey();
        }
    }
}
