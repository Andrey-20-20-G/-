using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КМЗИ_Лабы.Алфавит
{
    public class En
    {
        private char[] Eng { get; set; }
        public int AlphCount { get; } = 26;
        public En()
        {
            char[] alph = new char[]
            {
                'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'
            };
            Eng = alph;
        }

        public string GetAlph(int[] index)
        {
            int counter = 0;
            var mass = new char[index.Length];
            for (int j = 0; j < index.Length; j++)
            {
                for (int i = 0; i < Eng.Length; i++)
                {
                    if (i == index[j])
                    {
                        mass[j] = Eng[i];
                        counter++;
                        break;
                    }
                }
            }
            if (counter < index.Length)
            {
                return "Error!!!";
            }
            string mess = new string(mass);
            return mess;
        }

        public int[] GetAlph(string symbol)
        {
            int counter = 0;
            var mass = new int[symbol.Length];
            for (int j = 0; j < symbol.Length; j++)
            {
                for (int i = 0; i < Eng.Length; i++)
                {
                    if (Eng[i] == symbol[j])
                    {
                        mass[j] = i;
                        counter++;
                        break;
                    }
                }
            }
            if (counter < symbol.Length - 1)
            {
                mass[0] = -1;
            }
            return mass;
        }
    }
}
