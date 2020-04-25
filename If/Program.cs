using System;

namespace If
{
    class Program
    {
        static void Main()
        {
            if30();
        }

        static void if1()
        {
            int a = -50;

          //  a = (a > 0) ? a + 1 : Console.WriteLine(a);
        }
        static void if2()
        {
            int a = 50;

            if (a > 0)
            {
                a++;
            
            }
            else
            {
                a -= 2;
               
            }

            Console.WriteLine(a);
        }
        static void if3()
        {
            int a = -50;

            if (a > 0)
            {
                a++;
                Console.WriteLine(a);
            }
            else if (a == 0)
            {
                a = 10;
                Console.WriteLine(a);
            }
            else
            {
                a -= 2;
                Console.WriteLine(a);
            }
        }
        static void if4()
        {
            int a = -50;
            int b = 25;
            int c = 14;

            int positive_digit = 0;


            if (a > 0)
            {
                positive_digit++;
            }

            if (b > 0)
            {
                positive_digit++;
            }

            if (c > 0)
            {
                positive_digit++;
                
            }

            Console.WriteLine(positive_digit);
        }
        static void if5()
        {
            int a = -50;
            int b = 25;
            int c = 14;

            int PositiveDigit = 0;
            int negative_digit = 0;


            if (a > 0)
            {
                PositiveDigit++;
            }
            else if(a < 0)
            {
                negative_digit++;
            }

            if (b > 0)
            {
                PositiveDigit++;
            }
            else if (b < 0)
            {
                negative_digit++;
            }

            if (c > 0)
            {
                PositiveDigit++;
                
            }
            else if (c < 0)
            {
                negative_digit++;
                
            }


            Console.WriteLine(PositiveDigit);
            Console.WriteLine(negative_digit);
        }
        static void if6()
        {
            int a, b;
            a = 57;
            b = 149;

            if(a > b)
            {
                 Console.WriteLine(a);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
        static void if7()
        {
            int a, b;
            a = 57;
            b = 149;

            if (a > b)
            {
                Console.WriteLine('1');
            }
            else
            {
                Console.WriteLine('2');
                
            }
        }
        static void if8()
        {
            int a, b;
            a = 57;
            b = 149;

            if (a > b)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            }
            else
            {
                Console.WriteLine(b);
                Console.WriteLine(a);
            }
        }
        static void if9()
        {
            int A, B;
            A = 100;
            B = 50;

            if (B > A)
            {
                A = B;
                Console.WriteLine("A= " + A);
            }
            else
            {
                B = A;
                Console.WriteLine("B= " + A);
            }
        }
        static void if10()
        {
            int A, B;
            A = 100;
            B = 50;
            int sum = A + B;

            if (B != A)
            {
                A = sum;
                B = sum;

                Console.WriteLine($"{A} {B}");
            }
            else
            {
                A = B = 0;
                Console.WriteLine($"{A} {B}");
            }
        }
        static void if11()
        {
            int A, B;
            A = 100;
            B = 50;
            int sum = A + B;

            if (B != A)
            {
                A = A;
                B = A;

                Console.WriteLine($"{A} {B}");
            }
            else
            {
                A = B = 0;
                Console.WriteLine($"{A} {B}");
            }
        }
        static void if12()
        {
            int A, B, C;
            A = 100;
            B = 50;
            C = 25;
            int smallest_digit;


            if (C < A && C < B)
            {
                smallest_digit = C;

                Console.WriteLine("The smallest digit is  " + smallest_digit);
            }else if(A < C && A < B)
            {
                smallest_digit = A;

                Console.WriteLine("The smallest digit is  " + smallest_digit);
            }
            else if (B < C && B < A)
            {
                smallest_digit = B;

                Console.WriteLine("The smallest digit is  " + smallest_digit);
            }
        }
        static void if13()
        {
            int A, B, C;
            A = 100;
            B = 50;
            C = 25;
            int average_value;


            if (C > A && C < B)
            {
                average_value = C;

                Console.WriteLine("The average value is  " + average_value);
            }
            else if (A > C && A < B)
            {
                average_value = A;

                Console.WriteLine("The  average value is  " + average_value);
            }
            else if (B > C && B < A)
            {
                average_value = B;

                Console.WriteLine("The average value is  " + average_value);
            }
        }
        static void if14()
        {
            int A, B, C;
            A = 5;
            B = 6;
            C = 7;


            if (C < A && C < B)
            {
                Console.WriteLine(C + " ");
            }

            if (A > B && A > C)
            {
                Console.WriteLine(A);
            }

            if (B > A && B > C)
            {
                Console.WriteLine(A);
            }
            
            if (A < B && A < C)
            {
                Console.WriteLine(A);
            }

            if (B < A && A < C)
            {
                Console.WriteLine(A);
            }
            
            if (C > A && C > B)
            {
                Console.WriteLine(C + " ");
            }


        }
        static void if15()
        {
            int A, B, C;
            A = 3;
            B = 34;
            C = 6;

            int hight_sum_digit_one = 0;
            int hight_sum_digit_two = 0;


            if (C > A && C < B)
            {
                hight_sum_digit_one += C;
            }

            if (A > C && A > B)
            {
                hight_sum_digit_one += A;
            }

            if (B > A && B < C)
            {
                hight_sum_digit_one += B;
            }

            if (C > A && C > B)
            {
                hight_sum_digit_two += C;
            }

            if (A > C && A < B)
            {
                hight_sum_digit_two += A;
            }

            if (B > A && B > C)
            {
                hight_sum_digit_two += B;
            }

            if (A > C && A > B)
            {
                hight_sum_digit_one += A;
            }

            if (B > A && B < C)
            {
                hight_sum_digit_two += B;
            }

            Console.WriteLine(hight_sum_digit_one + hight_sum_digit_two);


        }
        static void if16()
        {
            int A, B, C;
            A = 1;
            B = 2;
            C = 3;

            if(A < B && B < C && A < C)
            {
               A = A * 2;
               B = B * 2;
               C = C * 2;
            }
            else
            {
                A = -A;
                B = -B;
                C = -C;
            }

            Console.WriteLine($"{A} {B} {C}");
        }
        static void if17()
        {
            int A, B, C;
            A = 3;
            B = 2;
            C = 1;

            if (A < B && B < C && A < C)
            {
                A = A * 2;
                B = B * 2;
                C = C * 2;
            }
            else
            {
                A = -A;
                B = -B;
                C = -C;
            }

            Console.WriteLine($"{A} {B} {C}");
        }
        static void if18()
        {
            int A, B, C;
            A = 1;
            B = 3;
            C = 1;

            if (A == B)
            {
                Console.WriteLine('3');
            }
            else if (C == B)
            {
                Console.WriteLine('1');
            }
            else if (A == C)
            {
                Console.WriteLine('2');
            }
        }
        static void if19()
        {
            int A, B, C, D;
            A = 12;
            B = 12;
            C = 11;
            D = 12;

            if (A == B && B == C && A == C && A != D && B != D && C != D)
            {
                Console.WriteLine('4');
            }
            else if (B == C && C == D && B == D && C != A && B != A && C != A)
            {
                Console.WriteLine('1');
            }
            else if (A == C && A == D && D == C && A != B && C != B && A != D)
            {
                Console.WriteLine('2');
            }
            else if (A == B && B == D && D == A && A != C && B != C && D != C)
            {
                Console.WriteLine('3');
            }
        }
        static void if20()
        {
            int A, B, C;
            A = 12;
            B = 14;
            C = 11;
            

            if (B > A && B < C)
            {
                int distance_from_a_to_b = A % B;
                
                Console.WriteLine("B , distance =" + distance_from_a_to_b);
            }
            else if(C > A && C < B)
            {
                int distance_from_a_to_c = A % C;


                Console.WriteLine("C , distance =" + distance_from_a_to_c);
            }

        }
        static void if21()
        {
            int OX, OY, OZ;
            OX = 0;
            OY = 0;
            OZ = 25;


            if (OX < 0 && OY > 0)
            {
                int OX_position = 1;
                Console.WriteLine(OX_position);
            }
            else if (OY > 0 && OX < 0)
            {
                int OY_position = 2;
                Console.WriteLine(OY_position);
            }
            else if (OX < 0 && OY < 0)
            {
                Console.WriteLine('0');
            }
            else
            {
                Console.WriteLine('3');
            }
        }
        static void if22()
        {
            int x, y;
            x = 0;
            y = 0;


            if ((x>0) & (y>0))
            {
                int OX_position = 1;
                Console.WriteLine(OX_position);
            }
            else if ((x<0) & (y>0))
            {
                int OY_position = 2;
                Console.WriteLine(OY_position);
            }
            else if ((x<0) & (y<0))
            {
                Console.WriteLine('0');
            }
            else
            {
                Console.WriteLine('3');
            }
        }
        static void if23()
        {
            int x1, y1, x2, y2, x3, y3;

            x1 = 85;
            x2 = 31;
            x3 = 58;

            y1 = 51;
            y2 = 62;
            y3 = 34;

            if (x2 == x3) {
                Console.WriteLine(x1);
                   } 
            else if (x3 == x1){
                Console.WriteLine(x2);
                   }
            else {
                Console.WriteLine(x3);
            }
            if (y2 == y3)
            {
                Console.WriteLine(y1);
                   }
            else if (y3 == y1)
            {
                Console.WriteLine(x2);
                   }
            else
            {
                Console.WriteLine(y3);
            }
        }
        static void if24()
        {
            double f = 7;
            double x = 5;

            if (x > 0)
            {
                f = 2 * Math.Sin(x);
                Console.WriteLine(f);
            }
            else { 
                f = 6 - x;
                Console.WriteLine(f);
            } 
        }
        static void if25()
        {
            int f;
            int x = 5;

            if (x < -2 || x > 2)
            {
                f = 2 * x;
                Console.WriteLine(f);
            }
            else
            {
                f = -3 * x;
                Console.WriteLine(f);
            }
        }
        static void if26()
        {
            int f;
            int x = 5;

            if (x <= 0)
            {
                f = -x;
                Console.WriteLine(f);
            }
            else if(x > 0 && x < 2)
            {
                f = x * x;
                Console.WriteLine(f);
            }
            else if(x >= 2)
            {
                f = 4;
            }
        }
        static void if27()
        {
            int f;
            int x = 5;

            if (x < 0)
            {
                f = 0;
                Console.WriteLine(f);
            }
            else if (x >= 0 && x < 1 && x >= 2 && x < 3)
            {
                f = 1;
                Console.WriteLine(f);
            }
            else if (x >= 1 && x < 2 && x >= 3 && x < 4)
            {
                f = -1;
            }
        }
        static void if28()
        {
            int Y = 1209;

            if ((Y % 100) == 0)
                if ((Y % 400) == 0)
                {
                    Console.WriteLine("366");
                }
                else
                {
                    Console.WriteLine("365");
                }
                else if((Y % 4) == 0) 
                { 
                    Console.WriteLine("366");
                } 
                else 
                { 
                    Console.WriteLine("365");
                } 
        }
        static void if29()
        {
            int digit = 10;

            if (digit < 0 && (digit % 2) == 0)
            {
                Console.WriteLine("отрицательное четное число");
            }
            else if (digit < 0 && (digit % 2) != 0)
            {
                Console.WriteLine("отрицательное нечетное число");
            }
            else if (digit > 0 && (digit % 2) != 0)
            {
                Console.WriteLine("положительное нечетное число");
            }
            else if (digit > 0 && (digit % 2) == 0)
            {
                Console.WriteLine("положительное четное число");
            }
            else if (digit == 0)
            {
                Console.WriteLine("нулевое число");
            }
        }
        static void if30()
        {
            int digit = 10;

            if ((digit / 100) < 10 && (digit % 2) == 0)
            {
                Console.WriteLine("четное двузначное число");
            }
            else if ((digit / 100) > 1 && (digit % 2) != 0)
            {
                Console.WriteLine("нечетное трехзначное число");
            }
            else if ((digit / 100) < 1 && (digit % 2) != 0)
            {
                Console.WriteLine("нечетное двузначное число");
            }
            else if ((digit / 100) > 1 && (digit % 2) != 0)
            {
                Console.WriteLine("четное трехзначное число");
            }


        }

        //DONE


    }
}
