using System;
using System.Security.Cryptography;

namespace While
{
    class Program
    {
        static void Main()
        {
            While26();
        }
        static void While1()
        {
            int A = 13;
            int B = 20;
            int Size = B - A;


            while (B < Size)
            {
                Size++;
            }

            Console.WriteLine(Size);
        }
        static void While2()
        {
            int A = 13;
            int B = 200;
            int Size = A;
            int Result = 1;


            while (B > Size)
            {
                Size++;
                Result = Size / A;
            }

            Console.WriteLine(Result);
        }
        static void While3()
        {
            int N = 200;
            int K = 200;
            int Digit = 0;
            int Result = 0;


            while (Digit < K)
            {
                Result = N % K;
                Digit++;  
            }

            Console.WriteLine(Result);
        }
        static void While4()
        {
            int N = 200;
            int Digit = 0;
            bool Result = true;


            while (Digit < N)
            { 
                Digit++;
                if (Digit % 3 == 0)
                {
                    Result = true;
                }else if (Digit % 3 != 0)
                {
                    Result = false;
                }
            }

            Console.WriteLine(Result);
        }
        static void While5()
        {
            int N = 200;
            int K = 0;


            while (N >= 2)
            {
                K++;
                N /= 2;
            }

            Console.WriteLine(K);
        }
        static void While6()
        {
            int N = 200;
            int Result = 1;


            while (N >= 2)
            {
                Result *= N;
                N /= 2;
            }

            Console.WriteLine(N);
        }
        static void While7()
        {
            int N = 200;
            int K = 1;


            while (K * K > N)
            {
                K++;
            }

            Console.WriteLine(K);
        }
        static void While8()
        {
            int N = 200;
            int K = 1;


            while (K * K <= N)
            {
                K++;
            }

            Console.WriteLine(K - 1);
        }
        static void While9()
        {
            int N = 200;
            int K = 1;
            int DoubleSize = 3 * 3;


            while (DoubleSize > N)
            {
                DoubleSize *= 3;
                K++;
            }

            Console.WriteLine(K);
        }
        static void While10()
        {
            int N = 200;
            int K = 1;
            int DoubleSize = 3;


            while (DoubleSize < N)
            {
                DoubleSize *= 3;
                K++;
            }

            Console.WriteLine(K - 1);
        }
        static void While11()
        {
            int N = 200;
            int K = 1;
            int DoubleSize = 3;


            while (DoubleSize <= N)
            {
                K++;
                DoubleSize += 3;
            }

            Console.WriteLine(K);
        }
        static void While12()
        {
            int N = 200;
            int K = 1;
            int DoubleSize = 3;


            while (DoubleSize <= N)
            {
                K++;
                DoubleSize += K;
            }

            Console.WriteLine(K - 1);
        }
        static void While13()
        {
            int A = 200;
            int K = 1;
            int Result = 0;


            while (K <= A)
            {
                K++;
                Result += 1 / K;
            }

            Console.WriteLine(Result);
        }
        static void While14()
        {
            int A = 200;
            int K = 1;
            int Result = 0;


            while (K <= A)
            {
                K++;
                Result += 1 / K;
            }

            Console.WriteLine(Result - 1);
        }
        static void While15()
        {
            int S = 1000;
            int K = 0;
            int Prosent = 20;


            while (S < 1100)
            {
                K++;
                S += S * Prosent / 100;
                
            }

            Console.WriteLine(K);
        }
        static void While16()
        {
            int S = 10;
            int K = 0;
            int P = 20;
            int DistanceProsent = 10;


            while (S < 200)
            {
                K++;
                DistanceProsent += DistanceProsent * P / 100;
                S += DistanceProsent;
            }

            Console.WriteLine($"{K} {S}");
        }
        static void While17()
        {
            int N = 657;
            


            while (N > 0)
            {
                Console.WriteLine(N % 10);
                N /= 10;
            }

            
        }
        static void While18()
        {
            int N = 657;
            int SumOfDigit = 0;
            int NumberOfDigit = 0;


            while (N > 0)
            {
                NumberOfDigit++;
                SumOfDigit += N % 10;
                N /= 10;
            }

            Console.WriteLine($"{SumOfDigit} {NumberOfDigit}");
        }
        static void While19()
        {
            int N = 657;
            int Result = 1;


            while (N > 0)
            {
                Result = Result * 10 + N % 10;
                N /= 10;
            }

            Console.WriteLine(Result);
        }
        static void While20()
        {
            int N = 657;
            int Result = 0;


            while ((N > 0) & ((N % 10) != 2))
            {
                N /= 10;
            }

            Console.WriteLine(Result);
        }
        static void While21()
        {
            int N = 657;


            while ((N > 0) & ((N % 10) == 0))
            {
                N /= 10;
            }

            Console.WriteLine((N % 10) % 2 != 0);
        }
        static void While22()
        {
            int N = 652;
            int K = 2;


            while (K < N & (N % K) != 0)
            {
                K++;
            }

            Console.WriteLine(N % K != 0);
        }
        static void While23()
        {
            int A = 7;
            int B = 10;

            while ((A > 0) & (B > 0) || (A < 0) & (B < 0))
            {
                if (A > B)
                {
                    A = A % B;
                }
                else
                { 
                    B = B % A;
                } 
            }

            Console.WriteLine(A + B);
        }
        static void While24()
        {
            int N = 7;
            int F = 0;
            int F1 = 1;
            int F2 = 1;

            while (F < N)
            {
                F = F1 + F2;
                F2 = F + F1;
                F1 = F;
            }

            Console.WriteLine(F == N);
        }
        static void While25()
        {
            int N = 7;
            int F = 0;
            int F1 = 1;
            int F2 = 1;

            while (F <= N)
            {
                F = F1 + F2;
                F2 = F + F1;
                F1 = F;
            }

            Console.WriteLine(F);
        }
        static void While26()
        {
            int N = 7;
            int F = 0;
            int F1 = 1;
            int F2 = 1;

            while (F < N)
            {
                F = F1 + F2;
                F2 = F + F1;
                F1 = F;
            }

            Console.WriteLine($"{"предыдущее ="} {F2} {"последующее ="} {F1 + F2}");
        }
        static void While27()
        {
            int N = 7;
            int K = 0;
            int F = 0;
            int F1 = 1;
            int F2 = 1;

            while (F < N)
            {
                K++;
                F = F1 + F2;
                F2 = F + F1;
                F1 = F;
            }

            Console.WriteLine(K);
        }
        static void While28()
        {
            int A = 2;
            int AK1 = 1;
            int ε = 100;
            int K = 2;

            while (A < ε)
            {
                K++;
                AK1 = A;
                A += 2 + 1 / AK1;
            }

            Console.WriteLine($"{K} {A} {AK1}");
        }






    }
}
