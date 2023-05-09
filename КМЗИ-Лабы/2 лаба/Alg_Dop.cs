using Matrix.Xmpp.XHtmlIM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using КМЗИ_Лабы.Алфавит;

namespace КМЗИ_Лабы._2_лаба
{
    public class Alg_Dop
    {
        public int[,] GetMatrix(int[,] matrix, int n, int rev)
        {
            var M = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    M[i, j] = 1;
                }
            }

            M[0,0] = matrix[1,1]*matrix[2,2]- matrix[2,1]*matrix[1,2];
            M[0, 1] = matrix[1, 0] * matrix[2, 2] - matrix[2, 0] * matrix[1, 2];
            M[0, 2] = matrix[1, 0] * matrix[2, 1] - matrix[2, 0] * matrix[1, 1];
            M[1, 0] = matrix[0, 1] * matrix[2, 2] - matrix[2, 1] * matrix[0, 2];
            M[1, 1] = matrix[0, 0] * matrix[2, 2] - matrix[2, 0] * matrix[0, 2];
            M[1, 2] = matrix[0, 0] * matrix[2, 1] - matrix[2, 0] * matrix[0, 1];
            M[2, 0] = matrix[0, 1] * matrix[1, 2] - matrix[1, 1] * matrix[0, 2];
            M[2, 1] = matrix[0, 0] * matrix[1, 2] - matrix[1, 0] * matrix[0, 2];
            M[2, 2] = matrix[0, 0] * matrix[1, 1] - matrix[1, 0] * matrix[0, 1];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if((i+j)%2!=0)
                    {
                        M[i, j] *= -1;
                    }
                    
                }
            }
            var getInt = new Ru();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    M[i,j] = ((M[i,j] % getInt.AlphCount) * rev) % 37;//
                }
                
            }
            int tmp;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <n; j++)
                {
                    if(i<j)
                    {
                        tmp = M[i,j];
                        M[i,j] = M[j,i];
                        M[j,i] = tmp;
                    }
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (M[i,j]<0)
                    {
                        M[i, j] += getInt.AlphCount;
                    }
                }
            }
            return M;
        }
    }
}
