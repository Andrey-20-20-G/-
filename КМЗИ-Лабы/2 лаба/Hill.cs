using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using КМЗИ_Лабы.Алфавит;


namespace КМЗИ_Лабы._2_лаба
{
    internal class Hill
    {
        //нйзя
        //ыхюн
        public void GetEncrypt(string message)
        {
            Console.WriteLine("Введите ключ");
            string key = Console.ReadLine();
            var getInt = new Ru();
            var mass = getInt.GetAlph(message);
            var key_int = getInt.GetAlph(key);
            var create_form = new Creator();
            var matrix = create_form.setCreator(mass, key_int).Item1;
            var array = create_form.setCreator(mass, key_int).Item2;
            var n = create_form.setCreator(mass, key_int).Item3;
            var list = ResInInt(matrix, array, n);
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
            var getInt = new Ru();
            var mass = getInt.GetAlph(message);
            var key_int = getInt.GetAlph(key);
            var create_form = new Creator();
            var matrix = create_form.setCreator(mass, key_int).Item1;
            var array = create_form.setCreator(mass, key_int).Item2;
            var n = create_form.setCreator(mass, key_int).Item3;
            var det = new Det();
            int det1 = det.GetDet(matrix, n);
            int x = det.GetEvk(det1, getInt.AlphCount);
            var alg_dop = new Alg_Dop();
            var KEY = alg_dop.GetMatrix(matrix, n, det.GetDetreverse(det1, x, getInt.AlphCount));
            var list = ResInInt(KEY, array, n);
            foreach (var item in list)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            //getInt.AlphCount
        }

        private List<string> ResInInt(int[,] matrix, int[] mass, int part)
        {
            var list = new List<string>();
            //int offset = 1;
            int trigger = part;
            while(trigger<=mass.Length)
            {
                var c = new int[part];
                for (int i = trigger - part; i < trigger; i++)
                {
                        c[i - (trigger - part)] = mass[i];
                }
                var calc = new Calc_matrix();
                var getString = new Ru();
                list.Add(getString.GetAlph(calc.Myltiply(c, matrix)));
                //offset++;
                trigger += part; 
            }
            return list;
          
        }
    }
}
