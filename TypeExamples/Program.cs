using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            FloatIssues();
        }
        static void TypeExample1()
        {
            int x = 4;
            var fields = x.GetType().GetFields();
            foreach(var value in fields)
            {
                Console.WriteLine($"{value.Name}");
            }
        }
        static void IntIssues()
        {
            int x = 1_000_000_000;
            Console.WriteLine(x * 4); //переполнение
            Console.Write(x * 4L);
            
            Console.WriteLine(7 / 2);//округление при делении
            double d = 7 / 2;  //строгая типизация в действии/ Сперва выполняется деление ИНТОВ? а только лишь потом присвоение результата дро,и
            Console.WriteLine(d);

            byte b = 6;
            //b = b * b; //error
            //Все маленькие типы при вычисления[ становяться интами
            b = (byte)(b * b);

            char c = 'd';
            Console.WriteLine(c);
            Console.WriteLine(c + 1);
            Console.WriteLine((char)(c + 1));
            Console.WriteLine(c + 0);
        }
        static void FloatIssues()
        {
            double d = 7 / 2;
            Console.WriteLine(d);
            Console.WriteLine((double)7 / 2);
            Console.WriteLine(7.0 / 2);

            double x = 645378645368743584384848868668834.745765476;
            double y = x;
            double res = x + 6 - y;
            Console.WriteLine(res);
            Console.WriteLine(x);
            
        }
    }
}
