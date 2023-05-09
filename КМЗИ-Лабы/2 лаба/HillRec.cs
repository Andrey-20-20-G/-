using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using КМЗИ_Лабы.Алфавит;

namespace КМЗИ_Лабы._2_лаба
{
    internal class HillRec
    {
        public void GetEncrypt(string message)
        {
            Console.WriteLine("Введите ключ");
            string key = Console.ReadLine();
            Console.WriteLine("Введите ключ 2");
            string key2 = Console.ReadLine();
            var getInt = new Ru();
            var mass = getInt.GetAlph(message);
            var key_int = getInt.GetAlph(key);
            var key_int2 = getInt.GetAlph(key2);
            var create_form = new Creator();
            var matrix = create_form.setCreator(mass, key_int).Item1;
            var matrix2 = create_form.setCreator(mass, key_int2).Item1;
            var array = create_form.setCreator(mass, key_int).Item2;
            var n = create_form.setCreator(mass, key_int).Item3;
            var list = ResInInt(matrix, matrix2, array, n);
            foreach (var item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();


        }
        public void GetDecrypt(string message)
        {
            Console.WriteLine("Введите ключ");
            string key = Console.ReadLine();
            Console.WriteLine("Введите ключ 2");
            string key2 = Console.ReadLine();
            var getInt = new Ru();
            var mass = getInt.GetAlph(message);
            var key_int = getInt.GetAlph(key);
            var key_int2 = getInt.GetAlph(key2);
            var create_form = new Creator();
            var matrix = create_form.setCreator(mass, key_int).Item1;
            var matrix2 = create_form.setCreator(mass, key_int2).Item1;
            var array = create_form.setCreator(mass, key_int).Item2;
            var n = create_form.setCreator(mass, key_int).Item3;
            var det = new Det();
            int det1 = det.GetDet(matrix, n);
            int x = det.GetEvk(det1, getInt.AlphCount);
            int det2 = det.GetDet(matrix2, n);
            int x2 = det.GetEvk(det2, getInt.AlphCount);
            var alg_dop = new Alg_Dop();
            var KEY = alg_dop.GetMatrix(matrix, n, det.GetDetreverse(det1, x, getInt.AlphCount));
            var KEY2 = alg_dop.GetMatrix(matrix2, n, det.GetDetreverse(det2, x2, getInt.AlphCount));
            var list = ResInInt(KEY, KEY2, array, n);
            foreach (var item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();
        }

        private List<string> ResInInt(int[,] matrix, int[,] matrix2, int[] mass, int part)
        {
            var list = new List<string>();
            int trigger = part;
            int step = 0;var matrix_helper = new int[part, part];
            matrix_helper = matrix;
            while (trigger <= mass.Length)
            {
                var c = new int[part];
                for (int i = trigger - part; i < trigger; i++)
                {
                        c[i - (trigger - part)] = mass[i];
                    
                }
                var calc = new Calc_matrix();
                var getString = new Ru();
                if (step < 1)
                {
                    list.Add(getString.GetAlph(calc.Myltiply(c, matrix_helper)));
                    matrix_helper = matrix2;
                    matrix = matrix2;
                }
                else
                {
                    list.Add(getString.GetAlph(calc.Myltiply(c, matrix_helper)));
                    matrix = matrix_helper;
                    matrix_helper = calc.MyltiplyMatrix(matrix, matrix_helper, part);
                }
                trigger += part;
            }
            return list;

        }
    }
}
