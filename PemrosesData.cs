using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod5_103022300023
{
    internal class PemrosesData
    {
        public T DapatkanNilaiTerbesar<T>(T A, T B, T C)
        {
            dynamic X = A;
            dynamic Y = B;
            dynamic Z = C;
            dynamic terbesar = X;

            if (X > Y && X > Z)
            {
                terbesar = X;
            } 
            else if (Y > X && Y > Z)
            {
                terbesar = Y;
            }
            else
            {
                terbesar = Z;
            }
            return terbesar;
        }
     }
} 
