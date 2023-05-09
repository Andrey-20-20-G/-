using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using КМЗИ_Лабы.Алфавит;

namespace КМЗИ_Лабы._2_лаба
{
    internal class Calc_matrix
    {
        public int[,] MyltiplyMatrix(int[,] matrix1, int[,] matrix2, int n)
        {
            int k = 0;
            var res = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    while (k < n)
                    {
                        res[i, j] = matrix1[i, k] * matrix2[k, j] + res[i, j];k++;
                    }
                    k = 0;
                    //res[i, j] %= 37;
                }
            }

            return res;
        }
        public int[] Myltiply(int[] mass, int[,] matrix)
        {
            var ru = new Ru();
            var res = new int[mass.Length];
            for (int i = 0; i < Math.Sqrt(matrix.Length); i++)
            {
                for (int j = 0; j < Math.Sqrt(matrix.Length); j++)
                {
                    res[i] = matrix[i, j] * mass[j] + res[i];
                }

                res[i] = res[i] % ru.AlphCount;
            }

            return res;
        }
        //public int[] Myltiply(int[] mass, int[,] matrix, int[,] matrix2)
        //{
        //    var ru = new Ru();
        //    var res = new int[mass.Length];
        //    int n = (int)Math.Sqrt(matrix.Length);
        //    var recMatrix = new int[n,n];
        //    recMatrix = matrix;
        //    for (int i = 0; i < Math.Sqrt(matrix.Length); i++)
        //    {
        //            for (int j = 0; j < Math.Sqrt(matrix.Length); j++)
        //            {
        //                res[i] = recMatrix[i, j] * mass[j] + res[i];
        //            }
        //            res[i] = res[i] % ru.AlphCount;
                
        //    }

        //    return res;
        //}
    }
}
