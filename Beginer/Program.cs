using System;

public class Begin
{
    
    public static void Main()
	{
		
	}
#region Tasks1-10
	static void Begin1()
	{
		int a = 10;
		int P = 4 * a;
		Console.WriteLine(P);

	}

	static void Begin2()
	{
		int a = 4;
		int S = a * a;
		Console.WriteLine(S);
	}

	static void Begin3()
	{
		int a = 7;
		int b = 10;
		int P = 2 * (a + b);
		int S = a * b;
		Console.WriteLine($"{P} {S}");
	}

	static void Begin4()
	{
		int d = 5;
		double L = Math.PI * d;
		Console.WriteLine(L);
	}

	static void Begin5()
	{
		int a = 12;
		int V = 12 * 12 * 12;
		int S = 6 * a * a;
		Console.WriteLine($"{V} {S}");
	}
	
	static void Begin6()
	{		
			int a = 9;
			int b = 14;
			int c = 3;


		int V = a * b * c;
		int S = 2 * (a * b + b * c + a * c);
		Console.WriteLine($"{V} {S}");
	}

	static void Begin7()
	{
		int R = 4;

		double L = 2 * Math.PI * R;
		double S = Math.PI * R * R;
		Console.WriteLine($"{L} {S}");
	}

	static void Begin8()
	{
		int a = 6;
		int b = 1;

		int Cnt = (a + b) / 2;
		Console.WriteLine(Cnt);
	}

	static void Begin9()
	{
		int a = 8;
		int b = 5;

		double Sq = Math.Sqrt(a * b);

		Console.WriteLine(Sq);
	}

	static void Begin10()
	{
		int a = 0;
		int b = 0;

		int s = a*a + b*b;
		int m = a*a - b*b;
		int p = a*a * b*b;
		int d = a*a /(b*b);

		Console.WriteLine($"{s} {m} {p} {d}");
	}
    #endregion
    static void Begin11()
	{
		int a = 0;
		int b = 0;

		int s = a + b;
		int m = a - b;
		int p = a * b;
		double d = Math.Abs(a) / Math.Abs(b);

		Console.WriteLine($"{s} {m} {p} {d}");
	}


	static void Begin12()
	{
		int a = 13;
		int b = 10;

		double c = Math.Sqrt(a * a + b * b);
		double P = a + b + c;

		Console.WriteLine($"{c} {P}");
	}

	static void Begin13()
	{
		int R1 = 8;
		int R2 = 5;

		double S1 = Math.PI * R1 * R1;
		double S2 = Math.PI * R2 * R2;
		double S3 = S1 - S2;

		Console.WriteLine(S3);
	}

	static void Begin14()
	{
		int L = 13;

		double R = L / (Math.PI * 2);
		double S = Math.PI * R * R;

		Console.WriteLine($"{R} {S}");
	}

	static void Begin15()
	{
		int S = 12;

		double R = Math.Sqrt(S / Math.PI);
		double L = 2 * Math.PI * R;
		double D = 2 * R;

		Console.WriteLine($"{L} {D}");
	}

	static void Begin16()
	{
		int x1 = 23;
		int x2 = 16;

		int mod = Math.Abs(x2 - x1);
		Console.WriteLine(mod);
	}

	static void Begin17()
	{
		int A = 4;
		int B = 10;
		int C = 13;

		int mod1 = Math.Abs(C - A);
		int mod2 = Math.Abs(C - B);

		int sum = mod1 + mod2;

		Console.WriteLine(sum);
	}

	static void Begin18()
	{
		int A = 6;
		int C = 9;
		int B = 17;

		int mod1 = Math.Abs(C - A);
		int mod2 = Math.Abs(B - C);

		int sum = mod1 * mod2;

		Console.WriteLine(sum);
	}

	static void Begin19()
	{
		int x1 = 0;
		int x2 = 19;
		int y1 = 0;
		int y2 = 10;

		int mod1 = Math.Abs(x2 - x1);
		int mod2 = Math.Abs(y2 - y1);

		int P = 2 * (mod1 + mod2);
		int S = mod1 * mod2;
	}

	static void Begin20()
	{
		int x1 = 5;
		int x2 = 16;
		int y1 = 7;
		int y2 = 13;

		double wdth = Math.Sqrt(x2 - x1 * x2 - x1 + y2 - y1 * y2 - y1);
	}

	static void Begin21()
	{
		int x1 = 4;
		int x2 = 19;
		int y1 = 2;
		int y2 = 10;
		int x3 = 7;
		int y3= 13;

		double a = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
		double b = Math.Sqrt(x3 - x2 * x3 - x2 + y3 - y2 * y3 - y2);
		double c = Math.Sqrt(x3 - x1 * x3 - x1 + y3 - y1 * y3 - y1);

		double P = (a + b + c) / 2;

		double S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));

		Console.WriteLine(S);
	}

	static void Begin22()
	{
		int A = 2;
		int B = 5;
			
			A = A + B;
			B = A - B;
			A = A - B;

		Console.WriteLine($"{A} {B}");
	}

	static void Begin22_2()
	{
		int A = 6;
		int B = 7;

		int temp = A;
		A = B;
		B = temp;

		Console.WriteLine($"{A} {B}");
	}

	static void Begin23()
	{
		int A = 2;
		int B = 5;
		int C = 7;

		A = A + C;
		C = A - C;
		A = A - C;

		B = B + C;
		C = B - C;
		B = B - C;

		Console.WriteLine($"{A} {B} {C}");
	}

	static void Begin24()
	{
		int A = 2;
		int B = 5;
		int C = 7;

		A = A + C;
		C = A - C;
		A = A - C;

		B = B + C;
		C = B - C;
		B = B - C;

		A = B + A;
		B = B - A;
		A = B - A;

		Console.WriteLine($"{A} {B} {C}");
	}

	static void Begin25()
	{
		int x = 10;
		int x6 = x * x * x * x * x * x;

		int y = 3 * x6 - 6 * (x / (x * x * x)) - 7 ;

		Console.WriteLine(y);
	}

	static void Begin26()
	{
		int x = 10;

		int y = x - 3;
		int y3 = y * y * y;
		int x6 = x - 3[] * x - 3 * x - 3 * x - 3 * x - 3 * x - 3 * x - 3;
		int x3 = x - 3 * x - 3 * x - 3;
		int y = 7 * x6 - 7 * x3 + 2;

		Console.WriteLine(y);


	}

	static void Begin27()
	{
		int A = 10;

		int A2 = A * A;

		int A4 = A2 * A2;

		int A8 = A4 * A4;

		Console.WriteLine($"{A} {A2} {A4} {A8}");
	}

	static void Begin28()
	{
		int A = 10;

		int A2 = A * A;

		int A3 = A2 * A;

		int A5 = A3 * A2;

		int A10 = A5 * A5;

		int A15 = A10 * A5;

		Console.WriteLine($"{A} {A2} {A3} {A5} {A10} {A15}");
	}

	static void Begin29()
	{
		int a = 130;

		double radian = Math.PI * a / 180;

		Console.WriteLine(radian);
	}

	static void Begin30()
	{
		int a = 3;

		double radian = 180 * a / Math.PI;

		Console.WriteLine(radian);
	}

	static void Begin31()
	{
		int Tf = 120;

		int Tc = (Tf - 32) * 5 / 9;

		Console.WriteLine(Tc);
	}

	static void Begin32()
	{
		int Tc = 19;

		int Tf = 9 * Tc / 5 + 32;

		Console.WriteLine(Tc);
	}

	static void Begin33()
	{

	}
}

public class Begin