using System;
class Program
{
    static void Main()
    {
        Proc20();
    }

    static int Sign(double X)
    {
        if (X < 0)
            return -1;
        if (X == 0)
            return 0;
        return 1;
    }
    static void Proc16()
    {
        double A = 3, B = -5;
        Console.WriteLine(Sign(A) + Sign(B));
    }

    static int RootsCount(int A, int B, int C)
    {
        double D = Math.Pow(B, 2) - 4 * A * C;
        if (D < 0)
            return 0;
        if (D == 0)
            return 1;
        return 2;
    }
    public static doble Proc17()
    {
        int A = 5;
        int B = 8;
        int C = 1;
        Console.WriteLine(RootsCount(A, B, C));
    }

    static string CircleS(double R)
    {
        double S = Math.Pow(R, 2);
        S = S * 3.14;
        return $"{S}";
    }
    static void Proc18()
    {
        double R = 6;
        Console.WriteLine(CircleS(R));
    }

    static string RingS(double R1, double R2)
    {
        double S1 = Math.Sqrt(R1 * 3.14);
        double S2 = Math.Sqrt(R2 * 3.14);
        return $"{S1} {S2}";
    }
    static void Proc19()
    {
        double R1 = 6;
        double R2 = 7;
        Console.WriteLine(RingS(R1, R2));
    }


    static double TriangleP(double a, double h)
    {
        double b = Math.Sqrt(Math.Pow(a / 2, 2) + Math.Pow(h, 2));
        return b + b + a;
    }
    static void Proc20()
    {
        double a = 6;
        double h = 7;
        Console.WriteLine(TriangleP(a, h));
    }

    static int SumRange(int A, int B)
    {
        int sum = 0;
        if (A > B)
        {
            return sum;
        }
        else
        {
            for (int i = A; i <= B; i++)
                sum += i;
            return sum;
        }
    }
    static void Proc21()
    {
        int A = 4;
        int B = 8;
        int C = 12;
        Console.WriteLine(SumRange(A, B));
        Console.WriteLine(SumRange(B, C));
    }

}