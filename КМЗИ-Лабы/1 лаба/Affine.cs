using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using КМЗИ_Лабы.Алгоритм_поиска_обратного_числа;
using КМЗИ_Лабы.Алфавит;

namespace КМЗИ_Лабы._1_лаба
{
    internal class Affine
    {
        public void GetEncrypt(string message)
        {
            Console.WriteLine("Введите два целочисленных положительных ключа");
            Console.WriteLine("Введите ключ a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ключ b:");
            int b = int.Parse(Console.ReadLine());
            int k;
            var getInt = new Ru();
            //var getInt = new En();
            var mass = getInt.GetAlph(message);
            for (int i = 0; i < mass.Length; i++)
            {
                k = a * mass[i] + b;
                if (a * mass[i] + b>= 0)
                {
                    mass[i] = k % getInt.AlphCount;
                }
                else
                {
                    while(k<0)
                    {
                        k += getInt.AlphCount;
                    }
                    mass[i] = k % getInt.AlphCount;
                }
            }
            Console.WriteLine(getInt.GetAlph(mass));
        }
        public void GetDecrypt(string message)
        {
            Console.WriteLine("Введите два целочисленных положительных ключа");
            Console.WriteLine("Введите ключ a:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ключ b:");
            int b = int.Parse(Console.ReadLine());
            var rev = new Reverse();

            var getInt = new Ru();
            //var getInt = new En();
            var mass = getInt.GetAlph(message);
            a = rev.GetReverse(getInt.AlphCount, a);
            int k;
            for (int i = 0; i < mass.Length; i++)
            {
                k = (mass[i] - b) * a;
                if (k >= 0)
                {
                    mass[i] = k % getInt.AlphCount;
                }
                else
                {
                    while(k<0)
                    k += getInt.AlphCount;
                    mass[i] = k % getInt.AlphCount;
                }
            }
            Console.WriteLine(getInt.GetAlph(mass));
        }
    }
}
