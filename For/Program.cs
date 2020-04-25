using System;
using System.Linq;
using System.Collections.Generic;

namespace For
{
    class Program
    {
        static void Main()
        {
            For19();
            
        }

        static void For1()
        {
            int K = 20;
            int N = 4;

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(K);
            }
        }
        static void For2()
        {
            int A = 20;
            int B = 30;

            for (int i = A; i <= B; i++)
            {
                Console.WriteLine(i);
            }
        }
        static void For3()
        {
            int A = 20;
            int B = 30;

            for (int i = B - 1; i > A; i--)
            {
                Console.WriteLine(i);
            }
        }
        static void For4()
        {
            int cost = 5;
            int kg = 0;

            for (int i = 0; i < 10; kg++)
            {
                i++;
                Console.WriteLine(kg * cost);
            }
        }
        static void For5()
        {
            int cost = 5;

            for (double i = 0.1; i < 1; i += 0.1)
            {
                Console.WriteLine(i * cost);
            }
        }
        static void For6()
        {
            int cost = 5;
            double kg = 0;

            for (double i = 1.2; i < 2; kg += 0.2)
            {
                i += 0.2;
                Console.WriteLine((kg / cost) + (kg % cost));
            }
        }
        static void For7()
        {
            int sum = 0;
            int A = 10;
            int B = 24;

            for (int i = A; i <= B; i += 1)
            {
                sum +=  i;
            }

            Console.WriteLine(sum);
        }
        static void For8()
        {
            
            int A = 10;
            int B = 24;
            int Product = 1;

            for (int i = A; i < B; i++)
            {
                Product *= i;
                
            }
            
            Console.WriteLine(Product);
        }
        static void For9()
        {

            int A = 10;
            int B = 24;
            int Product = 0;


            for(int i = A; i <= B; i++)
            {
                Product += i * i;
            }

            Console.WriteLine(Product);
            
        }
        static void For10()
        {

            int N = 10;


            for(int i = 0; i < N; i++)
            {
                Console.WriteLine(1 / i);
            }

        }
        static void For11()
        {

            int N = 10;
            

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine((N + i) * (N + i));
            }

        }
        static void For12()
        {

            int N = 10;
            double Result = 1;
            


            for (int i = 0; i <= N; i++)
            {
                Result *= 1.0 + (i / 10);
            }
            Console.WriteLine(Result);
        }
        static void For13()
        {

            double N = 1.1;
            double Result = 0;
            double Count = 0.1;


            for (double i = 2; i <= 10; i++)
            {
                Count += 0.1;
                if((i % 2) == 0)
                {
                    Result = N - (1 - Count);
                }else if((i % 2) != 0)
                {
                    Result = N - (1 + Count);
                }
            }
            Console.WriteLine(Result);
        }
        static void For14()
        {

            int N = 10;
            int Result = 1;


            for (int i = 2; i <= 10; i += 2)
            {
                Result = 1 + i + ((2 * N) - 1);
            }

            if(N * N == Result)
            {
                Console.WriteLine(Result);
            }else if(N * N != Result)
            {
                Console.WriteLine("");
            }
            
        }
        static void For15()
        {

            int a = 10;
            int N = 10;
            int Result = 1;

            for (int i = 1; i <= N; i++)
            {
                Result = a * a;
            }
        }
        static void For16()
        {
            int a = 10;
            int N = 10;
            float Result = 1;

            for (int i = 1; i <= N; i++)
            {
                Result *= (float)(a);
            }
            Console.WriteLine(Result);
        }    
        static void For17()
        {

            int a = 10;
            int N = 10;
            int Result = 1;

            for(int i = 2; i <= N; i++)
            {
                a *= a;
                Result += a;
            }
        }
        static void For18() 
        {

            int a = 10;
            int N = 10;
            int Result = 1;
            int MoreA = 1;

            for (int i = 2; i <= N; i++)
            {
                MoreA *= a * a;
                Result += MoreA - (1 * N);
            }

            Console.WriteLine(Result);
        }
        static void For19()
        {
            int N = 10;
            int Result = 1;

            for (int i = 2; i <= N; i++)
            {
                Result *= i;
            }

            Console.WriteLine(N);
        }
        static void For20()
        {
            int N = 10;
            int Result = 1;
            int MoreA = 1;


            for (int i = 1; i <= N; i++)
            {
                MoreA *= i;
                Result += MoreA;
            }

            Console.WriteLine(Result);
        }
        static void For21()
        {
            int N = 10;
            int Result = 1;
            int MoreA = 1;


            for (int i = 1; i <= N; i++)
            {
                MoreA *= i;
                Result += i/MoreA;
            }

            Console.WriteLine(Result);
        }
        static void For22()
        {
            int N = 10;
            int X = 5;
            int Result = 1;
            int MoreA = 1;


            for (int i = 1; i <= N; i += X)
            {
                MoreA *= i;
                Result +=  i / MoreA;
            }

            Console.WriteLine(Result);
        }
        static void For23()
        {
            int N = 10;
            int X = 5;
            int Result = 1;
            int MoreA = 1;


            for (int i = 1; i <= N; i += X)
            {
                MoreA *= (-1 * N) * i + 3;
                Result += MoreA;
            }

            Console.WriteLine(Result);
        }
        static void For24()
        {
            int N = 10;
            int X = 1;
            int XResult = 5;
            int Result = 1;
            int MoreA = 1;


            for (int i = 1; i <= N; i++)
            {
                MoreA++;
                N *= MoreA;
                MoreA++;
                N *= MoreA;
                XResult *= -1 * X * X;
                Result += XResult / N;
            }

            Console.WriteLine(Result);
        }
        static void For25()
        {
            int N = 10;
            int X = -20;
            int Result = 1;
            int MoreA = 1;


            for (int i = 1; i <= N; i++)
            {
                MoreA *= -1*X;
                Result += X/i;
            }

            Console.WriteLine(Result);
        }
        static void For26()
        {
            int N = 10;
            int X = -20;
            int Result = 1;
            int MoreA = 1;


            for (int i = 1; i <= N; i++)
            {
                MoreA *= (-1 * X) + 3;
                Result += X / i;
            }

            Console.WriteLine(Result);
        }
        static void For27()
        {
            int N = 10;
            int X = -20;
            int Result = 1;
            int MoreX = 1;
            int Act = 1;
            int Act2 = 1;


            for (int i = 1; i <= N; i++)
            {
                MoreX *= X * X;
                Act *= 2 * i - 1;
                Act2 *= 2 * i;  
                Result += Act * MoreX / (Act2 * (2 * i + 1));
            }

            Console.WriteLine(Result);
        }
        static void For28()
        {
            int N = 10;
            int X = -20;
            int Result = 1;
            int MoreX = 1;
            int Act = 1;
            int Act2 = 1;


            for (int i = 1; i <= N; i++)
            {
                Act *= 2 * i - 3;
                Act2 *= 2 * i;
                MoreX *= -1 * X;
                Result += Act * MoreX / Act2;
            }

            Console.WriteLine(Result);
        }
        static void For29()
        {
            int N = 10;
            int A = 5;
            int B = 29;
            int Result = 1;

            for(int i = A; i <= B; i++)
            {
                Result += A + (N * i);
            }

            Console.WriteLine(Result);
        }
        static void For30()
        {
            int H = 10;
            int A = 5;
            int B = 29;
            double Result = 1;


            for (int i = 0; i <= B; i++)
            {
                Result += 1 - Math.Sin(A + i * H);
            }

            Console.WriteLine(Result);
        }
        static void For31()
        {
            int A = 10;
            int K = 5;
            double Result = 1;


            for (int i = 0; i <= K; i++)
            {
                Result = 2 + (1 / (A * (K - 1)));
                Console.WriteLine(Result);
            }

            
        }
        static void For32()
        {
            int A = 10;
            int K = 5;
            double Result = 1;


            for (int i = 0; i <= K; i++)
            {
                Result = ((A * (K - 1)) + 1) / K;
                Console.WriteLine(Result);
            }

            
        }
        static void For33()
        {
            int N = 10;
            int K = 5;
            int F = 1;
            int F1 = 1;
            int F2 = 1;


            for (int i = 0; i <= N; i++)
            {
                F = (F1 * (K - 2)) + (F2 * (K - 1));
                Console.WriteLine(F);
            }

            
        }
        static void For34()
        {
            int A = 1;
            int A1 = 1;
            int A2 = 2;
            int N = 20;
            int K = 5;


            for (int i = 0; i <= N; i++)
            {
                A = (A1 * (K - 2)) + (2 * (A2 * (K - 1))) / 3;
                Console.WriteLine(A);
            }


        }
        static void For35()
        {
            int A = 1;
            int A1 = 1;
            int A2 = 2;
            int A3 = 3;
            int N = 20;
            int K = 5;


            for (int i = 0; i <= N; i++)
            {
                A = (A1 * (K - 1)) + (A2 * (K - 2)) - (2 * (A3 * (K - 3)));
                Console.WriteLine(A);
            }


        }
        static void For36()
        {
            int N = 10;
            int Result = 1;

            for (int i = 0; i <= N; i++)
            {
                int K = i;
                K += i;
                Result = i * K;
            }

            Console.WriteLine(Result);
        }
        static void For37()
        {
            int N = 10;
            int N1 = N;
            int N2 = 1;
            int Result = 1;

            for (int i = 0; i <= N; i++)
            {
                if (i != N)
                {
                    Result = i * N1;
                }
                
            }

            Console.WriteLine(Result);
        }



    }
}
