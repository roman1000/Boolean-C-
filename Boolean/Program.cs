using System;

namespace Boolean
{
    class Program
    {
        static void Main()
        {
            Boolean20();
        }

        public static bool Boolean1()
        {
            int A = 10;

            return A > 0;
        }

        public static bool Boolean2()
        {
            int A = 10;

            return A < 0;
        }

        public static bool Boolean3()
        {
            int A = 10;

            return (A % 2) == 0;
        }

        public static bool Bolean4()
        {
            int A = 10;
            int B = 20;

            return A > 2 && B <= 3;
        }

        public static bool Boolean5()
        {
            int A = 10;
            int B = 20;

            return A >= 0 || B < -2;
        }

        public static bool Boolean6()
        {
            int A = 10;
            int B = 20;
            int C = 30;

            return A < B && B < C && C > A;
        }

        public static bool Boolean7()
        {
            int A = 10;
            int B = 20;
            int C = 30;

            return A > B && B < C;
        }

        public static bool Boolean8()
        {
            int A = 10;
            int B = 20;

            return (A % 2) != 0 && (B % 2) != 0;
        }

        public static bool Boolean9()
        {
            int A = 10;
            int B = 20;

            return (A % 2) != 0 && (B % 2) == 0 || (A % 2) == 0 && (B % 2) != 0;
        }

        public static bool Boolean10()
        {
            int A = 10;
            int B = 20;

            return (A % 2) != 0 || (B % 2) != 0;
        }

        public static bool Boolean11()
        {
            int A = 10;
            int B = 20;

            return (A % 2) != 0 && (B % 2) != 0 || (A % 2) == 0 && (B % 2) == 0;
        }

        public static bool Boolean12()
        {
            int A = 10;
            int B = 20;
            int C = 30;

            return A > 0 && B > 0 && C > 0;
        }

        public static bool Boolean13()
        {
            int A = 10;
            int B = 20;
            int C = 30;

            return A > 0  || B > 0 || C > 0;
        }

        public static bool Boolean14()
        {
            int A = 10;
            int B = 20;
            int C = 30;

            return A > 0 && C < 0 && B < 0 || B > 0 && A < 0 && C < 0 || C > 0 && A < 0 && B < 0;
        }

        public static bool Boolean15()
        {
            int A = 10;
            int B = 20;
            int C = 30;

            return A > 0 && C > 0 && B < 0 || B > 0 && A > 0 && C < 0 || C > 0 && A > 0 && B < 0;
        }

        public static bool Boolean16()
        {
            int A = 10;

            return A > 9 && A < 100 && (A % 2) == 0;
        }

        public static bool Boolean17()
        {
            int A = 10;

            return A > 99 && A < 1000 && (A % 2) != 0;
        }

        public static bool Boolean18()
        {
            int A = 10;
            int B = 20;
            int C = 30;

            return A == B || A == C || C == B;
        }

        public static bool Boolean19()
        {
            int A = 10;
            int B = 20;
            int C = 30;

            return A == -B || A == -C || C == -B;
        }

        public static bool Boolean20()
        {
            int A = 354;

            int A_first_digit = A / 100;
            double A_sec_digit = (A % 100) / 10;
            double A_third_digit = A % 10;


            return A_first_digit != A_sec_digit && A_first_digit != A_third_digit && A_sec_digit != A_third_digit;
        }

        public static bool Boolean21()
        {
            int A = 354;

            int A_first_digit = A / 100;
            double A_sec_digit = (A % 100) / 10;
            double A_third_digit = A % 10;


            return A_first_digit < A_sec_digit && A_sec_digit < A_third_digit && A_first_digit < A_third_digit;
        }

        public static bool Boolean22()
        {
            int A = 354;

            int A_first_digit = A / 100;
            double A_sec_digit = (A % 100) / 10;
            double A_third_digit = A % 10;


            return A_first_digit < A_sec_digit && A_sec_digit < A_third_digit && A_first_digit < A_third_digit || A_first_digit > A_sec_digit && A_sec_digit > A_third_digit && A_first_digit > A_third_digit;
        }

        public static bool Boolean23()
        {
            int A = 3545;

            int A_first_digit = A / 1000;
            double A_sec_digit = (A % 1000) / 100;
            double A_third_digit = (A % 100) / 10;
            double A_f_digit = A % 10;

            return A_first_digit == A_f_digit && A_sec_digit == A_third_digit;
        }

        public static bool Boolean24()
        {
            int A = 10;
            int B = 20;
            int C = 30;

            int D = B * B - 4 * A * C;

            return D >= 0;
        }

        public static bool Boolean25()
        {
            int x = 10;
            int y = 20;

            return x < 0 && y > 0;
        }

        public static bool Boolean26()
        {
            int x = 10;
            int y = 20;

            return x > 0 && y < 0;
        }

        public static bool Boolean27()
        {
            int x = 10;
            int y = 20;

            return x > 0 && y > 0 || x < 0 && y > 0;
        }

        public static bool Boolean28()
        {
            int x = 10;
            int y = 20;

            return x > 0 && y > 0 || x < 0 && y < 0;
        }

        public static bool Boolean29()
        {
            int x = 10;
            int y = 20;
            int x2 = 40;
            int y2 = 50;
            int x3 = 70;
            int y3 = 80;

            return x2 < x & x < x3 & y3 < y & y < y2;
        }

        public static bool Boolean30()
        {
            int A = 10;
            int B = 20;
            int C = 30;

            return B == C && A == C && A == B;
        }

        public static bool Boolean31()
        {
            int A = 10;
            int B = 20;
            int C = 30;

            return B == C && A != C && A!= B;
        }

        public static bool Boolean32()
        {
            int A = 10;
            int B = 20;
            int C = 30;

            return A == (C / 2) && B == A*A + C*C;
        }

        public static bool Boolean33()
        {
            int A = 10;
            int B = 20;
            int C = 30;

            return A < (B + C) && B < (A + C) && C < (A + B);
        }
    }
}
