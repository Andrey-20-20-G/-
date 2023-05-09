using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КМЗИ_Лабы._2_лаба
{
    internal class Creator
    {
        public Tuple<int[,], int[], int> setCreator(int[] message, int[] key)
        {
            int plus = 0;
            int plus_for_mess = 0;
            while(((key.Length + plus)/9) != 1)
            {
                plus++;
            }
            int n = (int)Math.Sqrt(key.Length + plus);
            var matrix_key = new int[n,n];
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if(counter<key.Length)
                    {
                        matrix_key[i,j] = key[counter];
                        counter++;
                    }
                    else
                    {
                        matrix_key[i, j] = 27;
                    }
                }
            }
            while ((message.Length + plus_for_mess) % n != 0)
            {
                plus_for_mess++;
            }
            int m = message.Length + plus_for_mess;
            var message_mass = new int[m];
            for (int i = 0; i < message_mass.Length; i++)
            {
                if(i < message.Length)
                {
                    message_mass[i] = message[i];
                }
                else
                {
                    message_mass[i] = 10;
                }
            }

            return Tuple.Create(matrix_key, message_mass, n);
        }

    }
}
