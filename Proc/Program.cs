using System;

namespace Proc
{
    class Program
    {
        static void Main()
        {
            Sign(2);
        }

        static int Max(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }
        static int Sign(int X)
        {
            if(X < 0) return -1;
            else if(X == 0) return 0;
            else if(X > 0) return 1;
        }
        static int RootsCount(int A, int B, int C, int D)
        {
            D = (B * B) - 4 * A * C;

            if (D < 0) return -1;
            if (D == 0) return 0;
            if (D > 0) return 1;
        }
    }
}
