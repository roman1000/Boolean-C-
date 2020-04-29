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
            if (X < 0) return -1;
            else if (X == 0) return 0;
            else if (X > 0) return 1;
            else return 0;
        }
        static int RootsCount(int A, int B, int C)
        {
            int D = (B * B) - 4 * A * C;

            if (D < 0) return -1;
            else if (D == 0) return 0;
            else if (D > 0) return 1;
            else return 0;
        }
        static double CircleS(int R)
        {
            for (int i = 1; i <= 3; i++)
            {
                return Math.PI * (R * R);
            }
        }
        static double RingS(int R1, int R2)
        {


            for (int i = 1; i <= 3; i++)
            {
                return Math.PI * ((R1 * R1) - (R2 * R2));
            }
        }








    }
}
