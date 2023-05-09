using Matrix.Xmpp.XHtmlIM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace КМЗИ_Лабы._2_лаба
{
    internal class Det
    {
        public int GetDet(int[,] a, int n)
        {
            var b = new int[n*2];
            var det = 0;
            for (int i = 0; i < n*2; i++)
            {
                b[i] = 1;
            }
            for (int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                {
                    if ( i== j)
                    {
                        b[0] *= a[i,j];
                    }
                    if (i+j == n-1)
                    {
                        b[n] *= a[i, j];
                    }
                    
                    if(i+j == 1|| i+j == n+1)
                    {
                        b[n + 2] *= a[i, j];
                    }
                }
            }
            b[1] *= a[0, 2] * a[1, 0] * a[2, 1];
            b[2] *= a[0, 1] * a[1, 2] * a[2, 0];
            b[n + 1] *= a[0, 0] * a[1, 2] * a[2, 1];
            for (int i = 0; i < n * 2; i++)
            {
                if(i<n)
                {
                    det += b[i];
                }
                else
                {
                    det -= b[i];
                }
                
            }
            //выводим результат
            return det;
        }

        public int GetEvk(int det, int alph_length)
        {
            int r0 = det; int r1 = alph_length;int tmp_r, tmp_s, tmp_t, checker = alph_length, helper = r0/r1;
            int q = r0 / r1;
            int s0 = 1; int s1 = 0; int t0 = 0; int t1 = 1;
            while (checker != 0)
            {
                q = r0 / r1;
                tmp_r = r1;
                r1 = r0 - q * r1;
                r0 = tmp_r;

                tmp_s = s1;
                s1 = s0 - q * s1;
                s0 = tmp_s;

                tmp_t = t1;
                t1 = t0 - q * t1;
                t0 = tmp_t;
                
                helper = r0 / r1;
                checker = r0 - helper * r1;
            }
            return s1;
        }

        public int GetDetreverse(int det, int x, int alphCount)
        {
            int reverse;
            if(det>= 0)
            {
                if (x >= 0)
                {
                    reverse = x;
                }
                else
                {
                    reverse = x+alphCount;
                }
            }
            else
            {
                if (x >= 0)
                {
                    reverse = x;
                }
                else
                {
                    reverse = -x;
                }
            }
            return reverse;

        }
    }
}
