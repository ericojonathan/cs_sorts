using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace MatrixMultiplication
{
    class Program
    {
        static void Print2x2(int[,] m)
        {
            WriteLine("|{0} {1}|", m[0, 0], m[0, 1]);
            WriteLine("|{0} {1}|", m[1, 0], m[1, 1]);
        }
        static void Main(string[] args)
        {
            var m = new int[2, 2];
            m[0, 0] = 1; m[0, 1] = 2;
            m[1, 0] = 3; m[1, 1] = 4;
            WriteLine("Matrix A:");
            Print2x2(m);

            var a = m[0, 0];
            var b = m[0, 1];
            var c = m[1, 0];
            var d = m[1, 1];

            var n = new int[2, 2];
            n[0, 0] = 9; n[0, 1] = 8;
            n[1, 0] = 7; n[1, 1] = 6;
            WriteLine("Matrix B:");
            Print2x2(n);

            var e = n[0, 0];
            var f = n[0, 1];
            var g = n[1, 0];
            var h = n[1, 1];

            var o = new int[2, 2];
            o[0, 0] = a * e + b * g;
            o[0, 1] = a * f + b * h;
            o[1, 0] = c * e + d * g;
            o[1, 1] = c * f + d * h;
            WriteLine("Matrix A * B:");
            Print2x2(o);

        }
    }
}
