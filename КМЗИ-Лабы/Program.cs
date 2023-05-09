using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using КМЗИ_Лабы._1_лаба;
using КМЗИ_Лабы._2_лаба;
using КМЗИ_Лабы._3_лаба;
using КМЗИ_Лабы._4_лаба;

namespace КМЗИ_Лабы
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите действие (0 - Выйти из приложения, 1 - Зашифровать Аффинным шифром, 2 - Расшифровать Аффинным шифром," +
                "3 - Зашифровать Аффинно-рекурентным шифром, 4 - Расшифровать Аффинн-рекурентным шифром, " +
                "5 - Зашифровать шифром Хилла , 6 - Расшифровать шифром Хилла, 7 - Зашифровать рекуррентным шифром Хилла, " +
                "8 - Расшифровать рекуррентным шифром Хилла, 9 - Использовать шифр Виженера): ");
            int action = int.Parse(Console.ReadLine());
            while (action != 0)
            {
                switch (action)
                {
                    case 1:
                        {
                            Console.WriteLine("Введите сообщение");
                            var mess = Console.ReadLine();
                            var aff = new Affine();
                            aff.GetEncrypt(mess);
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Введите сообщение");
                            var mess = Console.ReadLine();
                            var aff = new Affine();
                            aff.GetDecrypt(mess);
                            break;
                        }
                        case 5:
                        {
                            Console.WriteLine("Введите сообщение");
                            var mess = Console.ReadLine();
                            var hill = new Hill();
                            hill.GetEncrypt(mess);
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Введите сообщение");
                            var mess = Console.ReadLine();
                            var affrec = new AffRec();
                            affrec.GetEncrypt(mess);
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Введите сообщение");
                            var mess = Console.ReadLine();
                            var affrec = new AffRec();
                            affrec.GetDecrypt(mess);
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Введите сообщение");
                            var mess = Console.ReadLine();
                            var hill = new Hill();
                            hill.GetDecrypt(mess);
                            break;
                        }
                        case 7:
                        {
                            Console.WriteLine("Введите сообщение");
                            var mess = Console.ReadLine();
                            var hillrec = new HillRec();
                            hillrec.GetEncrypt(mess);
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Введите сообщение");
                            var mess = Console.ReadLine();
                            var hillrec = new HillRec();
                            hillrec.GetDecrypt(mess);
                            break;
                        }
                        case 9:
                        {
                            var getAnswer = new GetAnswer();
                            getAnswer.GetMyAnswer();
                            break;
                        }
                    case 10:
                        {
                            var myRSA = new MyRSA();
                            myRSA.GetAnswer();
                            break;
                        }
                }
                Console.WriteLine("Выберите действие (0 - Выйти из приложения, 1 - Зашифровать Аффинным шифром, " +
                    "2 - Расшифровать Аффинным шифром," +
                "3 - Зашифровать Аффинно-рекурентным шифром, 4 - Расшифровать Аффинн-рекурентным шифром, " +
                "5 - Зашифровать шифром Хилла, 6 - Расшифровать шифром Хилла, 7 - Зашифровать рекуррентным шифром Хилла, " +
                "8 - Расшифровать рекуррентным шифром Хилла, 9 - Использовать шифр Виженера, 10 - RSA): ");
                action = int.Parse(Console.ReadLine());
            }
         
            //Console.ReadKey();
        }
    }
}
