using System;

namespace ineger
{
    class Program
    {


        static void Main()
        {
            Integer28();
        }
        #region done
        static void Integer1()
        {
            int L = 1564;


            int Meters = L / 100;

            Console.WriteLine(Meters);
        }
        static void Integer2()
        {
            int M = 240434;

            int Tons = M / 1000;

            Console.WriteLine(Tons);
        }
        static void Integer3()
        {
            int File_size_b = 412839;

            int File_size_kb = File_size_b / 1024;

            Console.WriteLine(File_size_kb);
        }
        static void Integer4()
        {
            int Width_A = 110;

            int Width_B = 25;

            int Width_none_A = Width_A / Width_B;

            Console.WriteLine(Width_none_A);
        }
        static void Integer5()
        {
            int Width_A = 110;

            int Width_B = 25;

            int Width_none_A = Width_A % Width_B;

            Console.WriteLine(Width_none_A);
        }
        static void Integer6()
        {
            int a = 28;

            int first_digit = a / 10;
            int second_digit = a % 10;

            Console.WriteLine($"{first_digit} {second_digit}");
        }
        static void Integer7()
        {
            int a = 19;

            int first_digit = a / 10;
            int second_digit = a % 10;

            int digits_sum = first_digit + second_digit;
            int digits_multiplication = first_digit * second_digit;

            Console.WriteLine($"{first_digit} {second_digit}");

        }
        static void Integer9()
        {
            int a = 591;

            int a_first_digit = a / 100;


            Console.WriteLine(a_first_digit);
        }
        static void Integer10()
        {
            int a = 847;

            int a_first_digit = a / 100;

            int a_second_digit = (a / 10) % 10;


            Console.WriteLine($"{a_first_digit}{a_second_digit}");
        }
        static void Integer11()
        {
            int a = 847;

            int a_first_digit = a / 100;

            int a_second_digit = (a / 10) % 10;

            int a_third_digit = a % 10;

            Console.WriteLine($"{a_first_digit}{a_second_digit}{a_third_digit}");
        }
        static void Integer12()
        {
            int a = 245;

            int a_first_digit =a % 10 ;

            int a_second_digit = (a / 10) % 10;

            int a_third_digit = a / 100;

            Console.WriteLine($"{a_first_digit}{a_second_digit}{a_third_digit}");
        }
        static void Integer13()
        {
            int a = 476;

            int a_first_digit = (a / 10) % 10;

            int a_second_digit = a % 10;

            int a_third_digit = a / 100;

            Console.WriteLine($"{a_first_digit}{a_second_digit}{a_third_digit}");
        }
        static void Integer14()
        {
            int a = 541;

            int a_first_digit = (a / 10) % 10;

            int a_second_digit = a / 100;

            int a_third_digit = a % 10;

            Console.WriteLine($"{a_first_digit}{a_second_digit}{a_third_digit}");
        }
        static void Integer15()
        {
            int a = 541;

            int a_first_digit = (a / 10) % 10;

            int a_second_digit = a / 100;

            int a_third_digit = a % 10;

            Console.WriteLine($"{a_first_digit}{a_second_digit}{a_third_digit}");
        }
        static void Integer16()
        {
            int a = 541;

            int a_first_digit = a / 100;

            int a_second_digit =a % 10 ;

            int a_third_digit = (a / 10) % 10;

            Console.WriteLine($"{a_first_digit}{a_second_digit}{a_third_digit}");
        }
        static void Integer17()
        {
            int a = 1200;

            int a_first_digit = (a / 100) % 10;

            Console.WriteLine($"{a_first_digit}");
        }
        static void Integer18()
        {
            int a = 1200;

            int a_first_digit = (a / 100) % 100;

            Console.WriteLine($"{a_first_digit}");
        }
        static void Integer19()
        {
            int N = 159035;

            int min = N / 60;

            int h = min / 60;

            int d = h / 24;

            Console.WriteLine($"{min} {h} {d}");
        }
        static void Integer20()
        {
            int N = 159035;


            int all_time_min = N / 60;

            int all_time_h = all_time_min / 60;


            int d = all_time_h / 24;

            int last_day_min = (N / 60) % d;

            int last_day_h = (last_day_min / 60) % d;

            Console.WriteLine($"{last_day_min} {last_day_h} {d}");
        }
        static void Integer21()
        {
            int N = 120815;


            int last_min_time = N % 60;

            

            Console.WriteLine($"{last_min_time}");
        }
        static void Integer22()
        {
            int N = 120815;


            int h = 60 * 60;

            int last_h_time = N % h;



            Console.WriteLine($"{last_h_time}");
        }
        static void Integer23()
        {
            int N = 5898123;


            int min = N / 60;

            int last_h_time = N % min;



            Console.WriteLine($"{last_h_time}");
        }
        static void Integer24()
        {
            int K = 26;

            Console.WriteLine(K % 7);

        }
        static void Integer25()
        {
            int K = 26;

            Console.WriteLine((K + 3) % 7);

        }
        static void Integer26()
        {
            int K = 26;

            Console.WriteLine((K % 7) + 1);

        }
        static void Integer27()
        {
            int K = 26;

            Console.WriteLine((K + 5) % 7);
        }
        static void Integer28()
        {
            int K = 26;
            int N = 5;

            Console.WriteLine(((K + 5) % 7) % N);
        }
        static void Integer29()
        {
            int A = 10;
            int B = 20;
            int C = 5;

            Console.WriteLine((A / C) * (B / C));
        }
        static void Integer30()
        {
            int year = 2019;

            Console.WriteLine((year / 100) + 1);
        }
        #endregion


        //DONE





    }
}
