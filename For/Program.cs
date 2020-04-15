using System;

namespace For
{
    class Program
    {
        static void Main()
        {
            For9();
        }

        static void For1()
        {
            int K = 20;
            int N = 10;

            for (int i = 0; i <= N; i++)
            {
                Console.WriteLine(K);
            }
        }
        static void For2()
        {
            int A = 20;
            int B = 30;

            for (int i = 0; i <= B; i++)
            {
                Console.WriteLine(A + i);
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
            double kg = 0;

            for (double i = 0; i < 1; kg += 0.1)
            {
                i+= 0.1;
                Console.WriteLine((kg / cost) + (kg % cost));
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

            for (int i = A; i < B; i += 1)
            {
                sum ++;
                Console.WriteLine(sum);
            }
        }
        static void For8()
        {
            
            int A = 10;
            int B = 24;

            for (int i = A; i < B; i += 1)
            {
               int sum = i;
                sum *= i;
                Console.WriteLine(sum);
            }
        }
        static void For9()
        {

            int A = 10;
            int B = 24;


            for (int i = A; i < B; i += 1)
            {
                int sum = i;
                sum = (sum * sum) * 2;
                Console.WriteLine(sum);
            }
        }
        static void For10()
        {

            int A = 10;
            int B = 24;


            for (int i = A; i < B; i += 1)
            {
                int sum = i;
                sum = (sum * sum) * 2;
                Console.WriteLine(sum);
            }
        }










    }
}
