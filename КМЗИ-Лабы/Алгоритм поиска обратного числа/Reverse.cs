using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КМЗИ_Лабы.Алгоритм_поиска_обратного_числа
{
    public class Reverse
    {
        public int GetReverse(int n, int a)
        {
            int q, r, y, y2, y1;
            r = 1; y2 = 0; y1 = 1;
            while (r != 0)
            {
                q = n / a; r = n % a;
                y = y2 - q * y1;
                n = a; a = r; y2 = y1; y1 = y;
            }
            return y2;
        }
    }
}
