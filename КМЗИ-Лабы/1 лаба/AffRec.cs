using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using КМЗИ_Лабы.Алгоритм_поиска_обратного_числа;
using КМЗИ_Лабы.Алфавит;

namespace КМЗИ_Лабы._1_лаба
{
    internal class AffRec
    {
        public void GetEncrypt(string message)
        {
            Console.WriteLine("Введите два целочисленных положительных ключа");
            Console.WriteLine("Введите ключ a1:");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ключ b1:");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ключ a2:");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ключ b2:");
            int b2 = int.Parse(Console.ReadLine());
            int k, a = a1, b = b1;
            //var getInt = new Ru();
            var getInt = new En();
            var mass = getInt.GetAlph(message);
            for (int i = 0; i < mass.Length; i++)
            {
                if(i<2)
                {
                    k = a * mass[i] + b;
                    if (a * mass[i] + b >= 0)
                    {
                        mass[i] = k % getInt.AlphCount;
                    }
                    else
                    {
                        while (k < 0)
                        {
                            k += getInt.AlphCount;
                        }
                        mass[i] = k % getInt.AlphCount;
                    }
                    a = a2;b= b2;
                }
                else
                {
                    k = a * mass[i] + b;
                    if (a * mass[i] + b >= 0)
                    {
                        mass[i] = k % getInt.AlphCount;
                    }
                    else
                    {
                        while (k < 0)
                        {
                            k += getInt.AlphCount;
                        }
                        mass[i] = k % getInt.AlphCount;
                    }
                    a = a1 * a2; b = b1 * b2;
                }
                
            }
            Console.WriteLine(getInt.GetAlph(mass));
        }
        public void GetDecrypt(string message)
        {
            Console.WriteLine("Введите два целочисленных положительных ключа");
            Console.WriteLine("Введите ключ a1:");
            int a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ключ b1:");
            int b1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ключ a2:");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите ключ b2:");
            int b2 = int.Parse(Console.ReadLine());
            int a = a1, b = b1;
            var rev = new Reverse();
            //var getInt = new Ru();
            var getInt = new En();
            var mass = getInt.GetAlph(message);
            
            int k;
            for (int i = 0; i < mass.Length; i++)
            {
                a = rev.GetReverse(getInt.AlphCount, a);
                if (i<2)
                {
                    k = (mass[i] - b) * a;
                    if (k >= 0)
                    {
                        mass[i] = k % getInt.AlphCount;
                    }
                    else
                    {
                        while (k < 0)
                            k += getInt.AlphCount;
                        mass[i] = k % getInt.AlphCount;
                    }
                    a = a2;b = b2;
                }
                else
                {
                    k = (mass[i] - b) * a;
                    if (k >= 0)
                    {
                        mass[i] = k % getInt.AlphCount;
                    }
                    else
                    {
                        while (k < 0)
                            k += getInt.AlphCount;
                        mass[i] = k % getInt.AlphCount;
                    }
                    a = a1 * a2; b = b1 * b2;
                }
               
            }
            Console.WriteLine(getInt.GetAlph(mass));
        }
    }
}
