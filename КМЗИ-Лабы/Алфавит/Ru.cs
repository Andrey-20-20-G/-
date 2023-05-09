using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace КМЗИ_Лабы.Алфавит
{
    internal class Ru
    {
        public char[] Rus { get; private set; }
        public int AlphCount { get; } = 37;
        public Ru() 
        {
            char[] alph = new char[]
            {
                'а','б','в','г','д','е','ё','ж','з','и','й','к','л','м','н','о','п','р','с','т','у','ф','х','ц','ч','ш','щ','ъ','ы','ь','э','ю','я','.',',',' ', '?'
            };
            Rus = alph;
        }

        public string GetAlph(int[] index)
        {
            int counter = 0;
            var mass = new char[index.Length];
            for (int j = 0; j < index.Length; j++)
            {
                for (int i = 0; i < Rus.Length; i++)
                {
                    if (i == index[j])
                    {
                        mass[j] = Rus[i];
                        counter++;
                        break;
                    }
                }
            }
            if(counter<index.Length)
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
                for (int i = 0; i < Rus.Length; i++)
                {
                    if (Rus[i] == symbol[j])
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
