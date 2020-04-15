using System;

namespace Case
{
    class Program
    {
        static void Main()
        {
            Case16();
        }

        static void Case1()
        {
            int day = 2;

            switch (day)
            {
                case 1:
                    Console.WriteLine("недельник");
                    break;

                case 2:
                    Console.WriteLine("вторник");
                    break;

                case 3:
                    Console.WriteLine("среда");
                    break;

                case 4:
                    Console.WriteLine("четверг");
                    break;

                case 5:
                    Console.WriteLine("пятница");
                    break;

                case 6:
                    Console.WriteLine("суббота");
                    break;

                case 7:
                    Console.WriteLine("воскресеннье");
                    break;

                default:
                    Console.WriteLine("число меньше 1 либо больше 7");
                    break;
            }
        }
        static void Case2()
        {
            int K = 5;

            switch (K)
            {
                case 1:
                    Console.WriteLine("плохо");
                    break;

                case 2:
                    Console.WriteLine("неудовлетворительно");
                    break;

                case 3:
                    Console.WriteLine("удовлетворительно");
                    break;
                case 4:
                    Console.WriteLine("хорошо");
                    break;

                case 5:
                    Console.WriteLine("отлично");
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }


        }
        static void Case3()
        {
            int month = 5;

            switch (month)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("зима");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("весна");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("лето");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("осень");
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
        }
        static void Case4()
        {
            int month = 6;

            switch (month)
            {
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30 дней");
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31 день");
                    break;
                case 2:
                    Console.WriteLine("28 дней");
                    break;
            }
        }
        static void Case5()
        {
            int A = 5;
            int B = 3;

            int N = 3;

            int result;

            switch (N)
            {
                case 1:
                    result = A + B;
                    Console.WriteLine(result);
                    break;
                case 2:
                    result = A + B;
                    Console.WriteLine(result);
                    break;
                case 3:
                    result = A * B;
                    Console.WriteLine(result);
                    break;
                case 4:
                    result = A / B;
                    Console.WriteLine(result);
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
        }
        static void Case6()
        {
            int size = 1304;
            int size_do = 3;
            int size_result;

            switch (size_do)
            {
                case 1:
                    size_result = (size / 10) + (size % 10);
                    Console.WriteLine(size_result);
                    break;
                case 2:
                    size_result = (size / 1000) + (size % 1000);
                    Console.WriteLine(size_result);
                    break;
                case 3:
                    size_result = (size / 100) + (size % 100);
                    Console.WriteLine(size_result);
                    break;
                case 4:
                    size_result = size * 1000;
                    break;
                case 5:
                    size_result = (size / 1) + (size % 1);
                    Console.WriteLine(size_result);
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
        }
        static void Case7()
        {
            int size = 1304;
            int m = size / 1000;
            int t = size * 1000;
            int size_do = 3;
            int size_result;

            switch (size_do)
            {
                case 1:
                    size_result = size / 1000;
                    Console.WriteLine(size_result);
                    break;
                case 2:
                    size_result = m;
                    Console.WriteLine(size_result);
                    break;
                case 3:
                    size_result = m * 1000;
                    Console.WriteLine(size_result);
                    break;
                case 4:
                    size_result = size * 1000;
                    Console.WriteLine(size_result);
                    break;
                case 5:
                    size_result = t * 10;
                    Console.WriteLine(size_result);
                    break;
                default:
                    Console.WriteLine("ошибка");
                    break;
            }
        }
        static void Case8()
        {
            int M = 5;
            int D;

            switch (M)
            {
                case 1:
                    D = 31;
                    break;
                case 3:
                    D = 31;
                    break;
                case 5:
                    D = 31;
                    break;
                case 7:
                    D = 31;
                    break;
                case 8:
                    D = 31;
                    break;
                case 10:
                    D = 31;
                    break;
                case 12:
                    D = 31;
                    break;
                case 4:
                    D = 30;
                    break;
                case 6:
                    D = 30;
                    break;
                case 9:
                    D = 30;
                    break;
                case 11:
                    D = 30;
                    break;
                case 2:
                    D = 28;
                    break;
            }
        }
        static void Case9()
        {
            int M = 10;
            int D = 34;

            switch (M)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if (D == 31) ;
                    {
                        D = 0;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if (D == 30)
                    {
                        D = 0;
                    }
                    break;
                case 2:
                    if (D == 28)
                    {
                        D = 0;
                    }
                    break;
            }
            if (D == 0)
            {
                if (M == 12)
                {
                    M = 1;
                }
            }
            else
            {
                M++;
            }
        }
        static void Case10()
        {
            string choice_string = "С";
            int choice_digit = -1;


            switch (choice_string)
            {
                case "С":
                    switch (choice_digit)
                    {
                        case 1:
                            Console.WriteLine("повернуть на запад");
                            break;
                        case 0:
                            Console.WriteLine("продолжить движение на север");
                            break;
                        case -1:
                            Console.WriteLine("повернуть на восток");
                            break;
                    }
                    break;
                case "В":
                    switch (choice_digit)
                    {
                        case 1:
                            Console.WriteLine("повернуть на ссевер");
                            break;
                        case 0:
                            Console.WriteLine("продолжить движение на восток");
                            break;
                        case -1:
                            Console.WriteLine("повернуть на юг");
                            break;
                    }
                    break;
                case "Ю":
                    switch (choice_digit)
                    {
                        case 1:
                            Console.WriteLine("повернуть на восок");
                            break;
                        case 0:
                            Console.WriteLine("продолжить движение на юг");
                            break;
                        case -1:
                            Console.WriteLine("повернуть на запад");
                            break;
                    }
                    break;
                case "З":
                    switch (choice_digit)
                    {
                        case 1:
                            Console.WriteLine("повернуть на юг");
                            break;
                        case 0:
                            Console.WriteLine("продолжить движение на запад");
                            break;
                        case -1:
                            Console.WriteLine("повернуть на север");
                            break;
                    }
                    break;
            }
        }
        static void Case11()
        {
            string choice_string = "С";
            int choice_digit = -1;


            switch (choice_string)
            {
                case "С":
                    switch (choice_digit)
                    {
                        case 1:
                            Console.WriteLine("повернуть на запад");
                            break;
                        case 2:
                            Console.WriteLine("продолжить движение на юг");
                            break;
                        case -1:
                            Console.WriteLine("повернуть на восток");
                            break;
                    }
                    break;
                case "В":
                    switch (choice_digit)
                    {
                        case 1:
                            Console.WriteLine("повернуть на ссевер");
                            break;
                        case 2:
                            Console.WriteLine("продолжить движение на запад");
                            break;
                        case -1:
                            Console.WriteLine("повернуть на юг");
                            break;
                    }
                    break;
                case "Ю":
                    switch (choice_digit)
                    {
                        case 1:
                            Console.WriteLine("повернуть на восок");
                            break;
                        case 2:
                            Console.WriteLine("продолжить движение на север");
                            break;
                        case -1:
                            Console.WriteLine("повернуть на запад");
                            break;
                    }
                    break;
                case "З":
                    switch (choice_digit)
                    {
                        case 1:
                            Console.WriteLine("повернуть на юг");
                            break;
                        case 2:
                            Console.WriteLine("продолжить движение на восток");
                            break;
                        case -1:
                            Console.WriteLine("повернуть на север");
                            break;
                    }
                    break;
            }
        }
        static void Case12()
        {
            int choice_digit = 3;
            int R = 10;
            int D = R * 2;
            double L = 2 * Math.PI * R;
            double S = (R * R) * Math.PI;


            switch (3)
            {
                case 1:
                    Console.WriteLine(R);
                    Console.WriteLine(D);
                    Console.WriteLine(L);
                    Console.WriteLine(S);
                    break;
                case 2:
                    Console.WriteLine(D);
                    Console.WriteLine(R);
                    Console.WriteLine(L);
                    Console.WriteLine(S);
                    break;
                case 3:
                    Console.WriteLine(D);
                    Console.WriteLine(L);
                    Console.WriteLine(R);
                    Console.WriteLine(S);
                    break;
                case 4:
                    Console.WriteLine(D);
                    Console.WriteLine(L);
                    Console.WriteLine(S);
                    Console.WriteLine(L);
                    break;
            }
        }
        static void Case13()
        {
            int choise = 1;

            int a = 4;
            double c = a * Math.Sqrt(2);
            double h = c / 2;
            double S = c * (h / 2);


            switch (choise)
            {
                case 1:
                    Console.WriteLine(a);
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                    Console.WriteLine(S);
                    break;
                case 2:
                    Console.WriteLine(c);
                    Console.WriteLine(a);
                    Console.WriteLine(h);
                    Console.WriteLine(S);
                    break;
                case 3:
                    Console.WriteLine(c);
                    Console.WriteLine(h);
                    Console.WriteLine(a);
                    Console.WriteLine(S);
                    break;
                case 4:
                    Console.WriteLine(c);
                    Console.WriteLine(h);
                    Console.WriteLine(S);
                    Console.WriteLine(a);
                    break;
            }
        }
        static void Case15()
        {
            int card = 7;
            int mast = 2;


            switch (card)
            {
                case 6:
                    Console.WriteLine("шестёрка ");
                    break;
                case 7:
                    Console.WriteLine("семёрка ");
                    break;
                case 8:
                    Console.WriteLine("восьмёрка ");
                    break;
                case 9:
                    Console.WriteLine("девятка ");
                    break;
                case 10:
                    Console.WriteLine("десятка ");
                    break;
                case 11:
                    Console.WriteLine("валет ");
                    break;
                case 12:
                    Console.WriteLine("дама ");
                    break;
                case 13:
                    Console.WriteLine("король ");
                    break;
                case 14:
                    Console.WriteLine("туз ");
                    break;
            }

            switch (mast)
            {
                case 1:
                    Console.WriteLine("пик");
                    break;
                case 2:
                    Console.WriteLine("треф");
                    break;
                case 3:
                    Console.WriteLine("бубен");
                    break;
                case 4:
                    Console.WriteLine("червей");
                    break;
            }
        }
        static void Case16()
        {
            int years = 27;

            if(years < 20 && years > 69)
            {
                Console.WriteLine("ошибка");
                    
            }
            else
            {

            
            switch (years / 10)
            {
                case 2:
                    Console.WriteLine("двадцать ");
                    break;
                case 3:
                    Console.WriteLine("тридцать ");
                    break;
                case 4:
                    Console.WriteLine("сорок ");
                    break;
                case 5:
                    Console.WriteLine("пятдесят ");
                    break;
                case 6:
                    Console.WriteLine("шестьдесят ");
                    break;
            }

            switch (years % 10)
            {
                case 1:
                    Console.WriteLine("один ");
                    break;
                case 2:
                    Console.WriteLine("два ");
                    break;
                case 3:
                    Console.WriteLine("три ");
                    break;
                case 4:
                    Console.WriteLine("четыре ");
                    break;
                case 5:
                    Console.WriteLine("пять ");
                    break;
                case 6:
                    Console.WriteLine("шесть ");
                    break;
                case 7:
                    Console.WriteLine("семь ");
                    break;
                case 8:
                    Console.WriteLine("восемь ");
                    break;
                case 9:
                    Console.WriteLine("девять ");
                    break;
            }

            switch (years % 10)
            {
                case 0:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("лет");
                    break;
                case 1:
                    Console.WriteLine("год");
                    break;
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("года");
                    break;
            }
            }
        }
        static void Case17()
        {
            int a = 14;
            if(a < 10 && a > 40)
            {
                Console.WriteLine("ошибка");
            }
            else
            {
                switch (a / 10)
                {
                    case 2:
                        Console.WriteLine("двадцать ");
                        break;
                    case 3:
                        Console.WriteLine("тридцать ");
                        break;
                    case 4:
                        Console.WriteLine("сорок ");
                        break;
                }

                switch (a % 10)
                {
                    case 1:
                        Console.WriteLine("один ");
                        break;
                    case 2:
                        Console.WriteLine("два ");
                        break;
                    case 3:
                        Console.WriteLine("три ");
                        break;
                    case 4:
                        Console.WriteLine("четыре ");
                        break;
                    case 5:
                        Console.WriteLine("пять ");
                        break;
                    case 6:
                        Console.WriteLine("шесть ");
                        break;
                    case 7:
                        Console.WriteLine("семь ");
                        break;
                    case 8:
                        Console.WriteLine("восемь ");
                        break;
                    case 9:
                        Console.WriteLine("девять ");
                        break;
                }

                switch (a % 10)
                {
                    case 0:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        Console.WriteLine("заданий");
                        break;
                    case 1:
                        Console.WriteLine("задание");
                        break;
                    case 2:
                    case 3:
                    case 4:
                        Console.WriteLine("задания");
                        break;
                }
            }
        }













    }
}
