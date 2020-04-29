using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.InteropServices;

namespace Series
{
    class Program
    {
        static void Main()
        {
            Siries25();
        }
        static void Siries1()
        {
            int[] Digit = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int Result = 0;

            for (int i = 0; i < Digit.Length; i++)
            {
                Result += Digit[i];
            }

            Console.WriteLine(Result);
        }
        static void Siries2()
        {
            int[] Digit = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int Result = Digit[0];

            for (int i = 0; i < Digit.Length; i++)
            {
                Result *= Digit[i];
            }

            Console.WriteLine(Result);
        }
        static void Siries3()
        {
            int[] Digit = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int Result = 0;

            for (int i = 0; i < Digit.Length; i++)
            {
                Result += Digit[i] / Digit.Length;
            }

            Console.WriteLine(Result);
        }
        static void Siries4()
        {
            int[] N = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int Result1 = 0;
            int Result2 = N[0];

            for (int i = 0; i < N.Length; i++)
            {
                Result1 += N[i];
                Result2 *= N[i];
            }

            Console.WriteLine($"{Result1} {Result2}");
        }
        static void Siries5()
        {
            double[] N = new double[] { 1, 2, 3.5, 4, 5.6, 6, 7, 8.2, 9, 10 };
            int Result = 0;


            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] % 1 == 0)
                {
                    Console.WriteLine(N[i]);
                    Result += (int)N[i];
                }
            }
            Console.WriteLine(Result);

        }
        static void Siries6()
        {
            double[] N = new double[] { 1, 2, 3.5, 4, 5.6, 6, 7, 8.2, 9, 10 };
            int Result = 0;


            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] % 1 != 0)
                {
                    Console.WriteLine(N[i]);
                    Result += (int)N[i];
                }
            }
            Console.WriteLine(Result);

        }
        static void Siries7()
        {
            double[] N = new double[] { 1, 2, 3.5, 4, 5.6, 6, 7, 8.2, 9, 10 };
            int Result = 0;


            for (int i = 0; i < N.Length; i++)
            {
                Result = (int)(N[i]);
                Console.WriteLine(Result);
            }


        }
        static void Siries8()
        {
            double[] N = new double[] { 1, 2, 3.5, 4, 5.6, 6, 7, 8.2, 9, 10 };
            int K = 0;


            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] % 2 == 0)
                {
                    K++;
                    Console.WriteLine(N[i]);
                    Console.WriteLine(K);
                }
            }


        }
        static void Siries9()
        {
            double[] N = new double[] { 1, 2, 3.5, 4, 5.6, 6, 7, 8.2, 9, 10 };
            int K = 0;


            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] % 2 != 0)
                {
                    K++;
                    Console.WriteLine(N[i]);
                    Console.WriteLine(K);
                }
            }


        }
        static void Siries10()
        {
            double[] N = new double[] { 1, 2, 3.5, 4, 5.6, 6, 7, 8.2, 9, 10 };
            int K = 0;
            bool Opinion = true;


            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] > 0)
                {
                    Opinion = true;
                }
                else
                {
                    Opinion = false;
                }
            }

            Console.WriteLine(Opinion);

        }
        static void Siries11()
        {
            double[] N = new double[] { 1, 2, 3.5, 4, 5.6, 6, 7, 8.2, 9, 10 };
            int K = 5;
            bool Opinion = true;


            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] < K)
                {
                    Opinion = true;
                }
                else
                {
                    Opinion = false;
                }
            }

            Console.WriteLine(Opinion);

        }
        static void Siries12()
        {
            double[] N = new double[] { 0, 0, 0, 0, 0 };
            int Count = 0;

            for (int i = 0; i < N.Length; i++)
            {
                Count++;
            }

            Console.WriteLine(Count);

        }
        static void Siries13()
        {
            double[] N = new double[] { 0, 0, 0, 0, 0 };
            int K = 1;

            for (int i = 0; i < N.Length && N[i] != 0; i++)
            {
                if (N[i] > K)
                {
                    Console.WriteLine(N[i]);
                }
            }
        }
        static void Siries14()
        {
            double[] N = new double[] { 0, 0, 0, 0, 0 };
            int K = 1;

            for (int i = 0; i < N.Length && N[i] != 0; i++)
            {
                if (N[i] < K)
                {
                    Console.WriteLine(N[i]);
                }
            }
        }
        static void Siries15()
        {
            double[] N = new double[] { 0, 0, 0, 0, 0 };
            int K = 1;
            int Stat = 0;

            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] > K)
                {
                    Console.WriteLine(N[i]);
                    i = N.Length;
                    Stat = 1;
                }
                else if (N[i] < K)
                {
                    Stat = -1;
                }
            }

            if (Stat < 0)
            {
                Console.WriteLine("0");
            }

        }
        static void Siries15_2()
        {
            double[] N = new double[] { 0, 0, 0, 0, 0 };
            int K = 1;


            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] > K)
                {
                    Console.WriteLine(N[i]);
                    return;
                }

            }

            Console.WriteLine(0);

        }
        static void Siries16()
        {
            int[] N = new int[] { 0, 4, 5, 6, 7, 0 };
            int K = 2;

            for (int i = N.Length - 1; i >= 0; i--)
            {
                if (N[i] > K)
                {
                    Console.WriteLine(N[i]);
                    return;
                }
            }
            Console.WriteLine(0);

        }
        static void Siries17()
        {
            int B = 5;
            int Nothing = 0;
            int[] N = new int[] { 1, 2, 3, 4, 6, 7, Nothing };
            int i = 0;


            while (N[i] < B)
            {
                Console.WriteLine(N[i]);
                i++;
            }
            Console.WriteLine(B);
            while (N[i] <= N.Length)
            {
                Console.WriteLine(N[i]);
                return;
            }

        }
        static void Siries18()
        {
            int Nothing = 0;
            int[] N = new int[] { 1, 2, 2, 3, 4, 5, 5, 6, 7, Nothing };

            for (int i = 0; i < N.Length - 1; i++)
            {
                if (N[i] != N[i + 1])
                {
                    Console.WriteLine(N[i]);
                }
            }
        }
        static void Siries19()
        {
            int Nothing = 0;
            int[] N = new int[] { 7, 7, 5, 3, 4, 7, 1, Nothing };
            int K = 0;



            for (int i = 1; i < N.Length - 1; i++)
            {
                if (N[i] < N[i - 1])
                {
                    Console.WriteLine(N[i]);
                    K++;
                }
            }
            Console.WriteLine("K = " + K);
        }
        static void Siries20()
        {
            int Nothing = 0;
            int[] N = new int[] { 1, 2, 3, 2, 4, 1, 6, Nothing };
            int K = 0;



            for (int i = 0; i < N.Length - 1; i++)
            {
                if (N[i] < N[i + 1])
                {
                    Console.WriteLine(N[i]);
                    K++;
                }
            }
            Console.WriteLine(K);
        }
        static void Siries21()
        {
            int Nothing = 0;
            int[] N = new int[] { 1, 2, 3, 4, 5, 6, 7, Nothing };
            int MoreIf = N[0];
            bool Grow = true;


            for (int i = 1; i < N.Length - 2; i++)
            {
                if (N[i] < N[i + 1] && N[i] > MoreIf && MoreIf + 1 == N[1])
                {
                    Grow = true;
                }
                else if (N[i] != N[i + 1])
                {
                    Grow = false;
                }
            }
            Console.WriteLine(Grow);
        }
        static void Siries22()
        {
            int Nothing = 0;
            int[] N = new int[] { 4, 3, 2, 1, Nothing };
            int MoreIf = N[0];


            for (int i = 1; i < N.Length - 2; i++)
            {
                if (N[i] > N[i + 1] && N[i] < MoreIf && MoreIf - 1 == N[1])
                {
                    Console.WriteLine(0);
                }
                else if (N[i] < N[i + 1])
                {
                    Console.WriteLine(N[i + 1]);
                }
            }

        }
        static void Siries23()
        {
            int Nothing = 0;
            int[] N = new int[] { 1, 2, 1, 2, 5, 2, Nothing };
            bool Saw = true;


            for (int i = 1; i < N.Length - 2; i += 2)
            {
                if (N[i] < N[i - 1] && N[i] < N[i + 1] || N[i] > N[i - 1] && N[i] > N[i + 1])
                {
                    Saw = true;
                }
                else if (N[i] > N[i - 1] && N[i] < N[i + 1] || N[i] < N[i - 1] && N[i] > N[i + 1])
                {
                    Console.WriteLine(N[i + 1]);
                    return;
                }
            }

            if (Saw == true)
            {
                Console.WriteLine(0);
            }

        }
        static void Siries24()
        {
            int Nothing = 0;
            int[] N = new int[] { Nothing ,21, 0, 15, 15, 0, 2 };
            bool Count = false;
            bool Stat = false;
            int Result = 0;

            for (int i = N.Length - 1; i > 0; i--)
            {
                if (Stat == false)
                {
                    if (N[i] == 0)
                    {
                        Count = true;
                        Stat = true;
                    }
                    else if (N[i] != 0)
                    {
                        Count = false;
                    }
                }
                if (Stat == true)
                {
                    if (Count == true)
                    {
                        Result += N[i];
                        if (N[i - 1] == 0)
                        {
                            break;
                        }
                    }
                }

            }

            Console.WriteLine(Result);

        }
        static void Siries25()
        {
            int Nothing = 0;
            int[] N = new int[] { 200, 0, 15, 15, 0, 2, Nothing };
            bool Count = false;
            bool Stat = false;
            int Result = 0;

            for (int i = 0; i < N.Length -1; i++)
            {
                if (Stat == false)
                {
                if (N[i] == 0)
                {
                    Count = true;
                    Stat = true;
                }
                else if(N[i] != 0)
                {
                    Count = false;
                }
                }
                if(N[i + 1] != 0)
                    Result += N[i];
                {
                if(Stat == true)
                {
                if (Count == true)
                {
                    Result += N[i];
                if (N[i + 1] == 0)
                {
                    break; 
                }     
                }
                }
                }
            }

            Console.WriteLine(Result);
        }
    }

} 

