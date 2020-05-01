using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Proc
{
    class Program
    {
        static void Main()
        {
            Proc29();
        }

        static int Max(int a, int b)
        {
            if (a > b) return a;
            else return b;
        }

        #region Proc 16
        static int Sign(double X)
        {
            if (X < 0) return -1;
            if (X == 0) return 0;
            return 1;
        }
        static void Proc16()
        {
            int A = 6;
            int B = 8;
            Console.WriteLine(Sign(A) + Sign(B));
        }
        #endregion
        #region Proc 17

        static int RootsCount(int A, int B, int C)
        {
            int D = (B * B) - 4 * A * C;

            if (D < 0) return 0;
            if (D == 0) return 1;
            return 2;
        }

        static void Proc17()
        {
            for (int i = 0; i < 3; i++)
            {
                int A;
                int B;
                int C;
                A = int.Parse(Console.ReadLine());
                B = int.Parse(Console.ReadLine());
                C = int.Parse(Console.ReadLine());
                Console.WriteLine(RootsCount(A, B, C));
            }

        }

        #endregion
        #region Proc 18

        static double CircleS(int R)
        {
            return Math.PI * (R * R);
        }

        static void Proc18()
        {  
        for (int i = 1; i <= 3; i++)
        {
            int Result = int.Parse(Console.ReadLine());
            Console.WriteLine(CircleS(Result));
        }
        }


        #endregion
        #region Proc 19
        static double RingS(int R1, int R2)
        {
            return Math.PI * ((R1 * R1) - (R2 * R2));
        }

        static void Proc19()
        {
            int Result1 = int.Parse(Console.ReadLine());
            int Result2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{RingS(Result1, Result2)}");
        }
        #endregion
        #region Proc 20
        static double TriangleP(int a, int h)
        {
            return (((a / 2) * (a / 2)) + (h * h)) + (a * 2);

        }

        static void Proc20()
        {

            for(int i = 0; i < 3; i++)
            {
            int Result1 = int.Parse(Console.ReadLine());
            int Result2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{TriangleP(Result1, Result2)}");
            }
            
        }
        #endregion
        #region Proc 21
        static double SumRange(int A, int B)
        {
            int Result = 0;
            if (A > B) return 0;
            for(int i = 1; i < B; i++)
            {
                return Result += 1;
            }

            return 0;

        }

        static void Proc21()
        {

            for (int i = 0; i < 3; i++)
            {
                int Result1 = int.Parse(Console.ReadLine());
                int Result2 = int.Parse(Console.ReadLine());
                Console.WriteLine($"{SumRange(Result1, Result2)}");
            }

        }
        #endregion
        #region Proc 22
        static double Calc(int A, int B, int Op)
        {
            switch (Op)
            {
                case 1:
                    return A - B;
                    break;
                case 2:
                    return A * B;
                    break;
                case 3:
                    return A / B;
                    break;
                default:
                    return A * B;
                    break;
            }

        }

        static void Proc22()
        {

            for (int i = 0; i < 3; i++)
            {
                int Result1 = int.Parse(Console.ReadLine());
                int Result2 = int.Parse(Console.ReadLine());
                int Act = int.Parse(Console.ReadLine());
                Console.WriteLine("N " + Calc(Result1, Result2, Act));
                
            }

        }
        #endregion
        #region Proc 23
        static double Quarter(int x, int y)
        {
            if(x > 0 && y > 0)
            {
                return 1;
            }
            if (x < 0 && y > 0)
            {
                return 2;
            }
            if (x < 0 && y < 0)
            {
                return 3;
            }
            return 4;

        }

        static void Proc23()
        {

            for (int i = 0; i < 3; i++)
            {
                int X = int.Parse(Console.ReadLine());
                int Y = int.Parse(Console.ReadLine());
                Console.WriteLine(Quarter(X, Y));

            }

        }
        #endregion
        #region Proc 24
        static bool Even(double K)
        {
            if(K % 1 == 0)
            {
                return true;
            }

            return false;
        }

        static void Proc24()
        {

            for (int i = 0; i < 10 - 1; i++)
            {
                double[] K = new double[] { 1, 2, 4.5, 1.2, 3, 5, 6, 4.4, 5};
                Console.WriteLine(Even(K[i]));

            }

        }
        #endregion
        #region Proc 25
        static bool IsSquare(double K)
        {
            if (Math.Sqrt(K) % 1 == 0)
            {
                return true;
            }

            return false;
        }

        static void Proc25()
        {

            for (int i = 0; i < 10 - 1; i++)
            {
                double[] K = new double[] { 1, 4, 4.5, 1.2, 4, 5, 9, 4.4, 5 };
                Console.WriteLine(IsSquare(K[i]));

            }

        }
        #endregion
        #region Proc 26
        static bool IsPower5(double K)
        {

            for(int i = 5; i < 1000; i *= 5)
            {
                if(i == K) return true;
            } 
            return false;
        }

        static void Proc26()
        {

            for (int i = 0; i < 10 - 1; i++)
            {
                double[] K = new double[] { 1, 5, 15, 25, 4, 25, 9, 4.4, 5 };
                Console.WriteLine(IsPower5(K[i]));

            }

        }
        #endregion
        #region Proc 27
        static bool IsPowerN(double K, int N)
        {

            for (int i = N; i < 1000; i *= N)
            {
                if (K == N) return true;
            }
            return false;
        }

        static void Proc27()
        {

            for (int i = 0; i < 10 - 1; i++)
            {
                double[] K = new double[] { 1, 5, 16, 25, 4, 25, 9, 4, 5 };
                Console.WriteLine(IsPowerN(K[i] , 4));

            }
        }
        #endregion
        #region Proc 28
        static int IsPrime(double N)
        {
            int Result = 0;
            if(N % 2 == 0)
            {
                Result++;
                
            }

            return Result;
            
        }


        static void Proc28()
        {
            double Result = 0;

            for (int i = 0; i < 10 - 1; i++)
            {
                double[] K = new double[] { 1, 5, 16, 25, 4, 25, 9, 4, 5 };
                Result += IsPrime(K[i]);
            }

            Console.WriteLine(Result);
            
        }
        #endregion
        #region Proc 29
        static int DigitCount(double K)
        {
            int i;
            for (i = 1; K >= 10; i++)
            {
                K /= 10;
            }
            
            return i;
        }


        static void Proc29()
        {
            for (int i = 1; i < 5; i++)
            {
                double[] K = new double[] { 1, 5, 16, 25, 5 };
                Console.WriteLine(DigitCount(K[i]));
            }

        }
        #endregion
        #region Proc 30
        static int DigitN(double K , int N)
        {
            int i = 1;
            for (i = 1; i <= N - 1; i++)
            {
                K /= 10;
            }
            if (K != 0) return (int)K % 10;
            else return -1;
        }


        static void Proc30()
        {
            for (int i = 1; i < 5; i++)
            {
                double[] K = new double[] { 1, 5, 16, 25, 5 };
                Console.WriteLine(DigitN(K[i], i) + " " + i);
            }

        }
        #endregion
        #region Proc 31
        static int IsPalindrom(double K)
        {
            int i;
            int Count;
            Count = DigitCount(K);
            for (i = 1; i <= Count; i++)
                if (DigitN(K, i) != DigitN(K, Count - i + 1)) return 0;
            return 1;
        }


        static void Proc31()
        {
            int i, K, Count2 = 0;
            for (i = 1; i <= 10; i++)
            {
                K = int.Parse(Console.ReadLine());
                Count2 += IsPalindrom(K);
            }
        }
        #endregion
        #region Proc 32
        static double DegToRad(double D)
        {
            return D * 3.14 / 180;
        }


        static void Proc32()
        {
            int K; 
            for (int i = 1; i <= 5; i++)
            {
                K = int.Parse(Console.ReadLine());
                Console.WriteLine(DegToRad(K));
            }
        }
        #endregion
        #region Proc 33
        static double RadToDeg(double R)
        {
            return 180 * R / 3.14;
        }


        static void Proc33()
        {
            int K;
            for (int i = 1; i <= 5; i++)
            {
                K = int.Parse(Console.ReadLine());
                Console.WriteLine(RadToDeg(K));
            }
        }
        #endregion














        #region Ref type
        static void Swap(ref int A,ref int B)//параметры
        {
            A = A + B;
            B = A - B;
            A = A - B;
        }
        static void Swap2(ref int A,ref int B)//параметры
        {
            A = A + B;
            B = A - B;
            A = A - B;
        }
        static void Proc()
        {
            int A = 10;//аргумент
            int B = 15;//аргумент

            Swap(ref A,ref B);//изменение копий аргументов
            Swap2(ref A, ref B);

            Console.WriteLine(A + " " + B);
        }
        #endregion
    }
}
