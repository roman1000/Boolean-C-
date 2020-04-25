using System;
using System.Diagnostics;
using System.Globalization;

namespace Series
{
    class Program
    {
        static void Main()
        {
            Siries17();
        }
        static void Siries1()
        {
            int[] Digit = new int[] {1 ,2 ,3 ,4 ,5 ,6 ,7 ,8 ,9 ,10};
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
                Result += Digit[i] / Digit.Length ;
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
                if(N[i] % 1 == 0)
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
                Result = (int)(N[i] / 1);
                Console.WriteLine(Result);
            }
            

        }
        static void Siries8()
        {
            double[] N = new double[] { 1, 2, 3.5, 4, 5.6, 6, 7, 8.2, 9, 10 };
            int K = 0;


            for (int i = 0; i < N.Length; i++)
            {
                if(N[i] % 2 == 0)
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

            for (int i = 0; i < N.Length; i++)
            {
                if(N[i] > K)
                {
                    Console.WriteLine(N[i]);
                }
            }
        }
        static void Siries14()
        {
            double[] N = new double[] { 0, 0, 0, 0, 0 };
            int K = 1;

            for (int i = 0; i < N.Length; i++)
            {
                if (N[i] > K)
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
                if(N[i] > K)
                {
                    Console.WriteLine(N[i]);
                    i = N.Length;
                    Stat = 1;
                }
                else if(N[i] < K)
                {
                    Stat = -1;
                }
            }

            if(Stat < 0)
            {
                Console.WriteLine("0");
            }

        }
        static void Siries16()
        {
            int[] N = new int[] { 0, 4, 5, 6, 7, 0 };
            int K = 2;
            int Stat = 1;

            for (int i = 0; i < N.Length; i++)
            {
                Stat++;
                if(N[i] > K && N[i + 1] < K)
                {
                    Console.WriteLine(N[i]);
                    i = N.Length;
                    Stat = 1;
                }
                else if(N[i] < K)
                {
                    Stat = -1;
                }

                
            }
                if(Stat < 0)
                {
                    Console.WriteLine("0");
                }
        }
        static void Siries17()
        {
            int B = 1;
            int[] N = new int[] { 0, 7, 2, 1, 5, 0, B };
            bool State = false;
            

            for (int i = 0; i < N.Length - 1; i++)
            {
                if(N[i] > N[i + 1])
                {
                    State = true;
                }
                if(State = true)
                {
                    Console.WriteLine(N[i]);
                }
                State = false;
            }
        }










    }
}
