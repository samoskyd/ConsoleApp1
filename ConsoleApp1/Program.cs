using System;
using System.Collections.Generic;

class Program
{
    public static void Main(string[] args)
    {
        Point A = new Point(3, 4);
        Point B = new Point(1, 6);
        Point C = new Point(5, 4);
        Point D = new Point(5, 5);
        Point E = new Point(3, 2);
        Point F = new Point(1, 1);
        Point G = new Point(2, 2);
        Point H = new Point(6, 3);
        Point I = new Point(4, 2);
        Point J = new Point(1, 2);

        //List<Point> l = new List<Point>();
        //l.Add(A);
        //l.Add(B);
        //l.Add(C);
        //l.Add(D);
        //l.Add(E);
        //l.Add(F);
        //l.Add(G);
        //l.Add(H);
        //l.Add(I);
        //l.Add(J);

        List<Point> fjg = new List<Point>();
        fjg.Add(F);
        fjg.Add(J);
        fjg.Add(G);

        List<Point> dch = new List<Point>();
        dch.Add(D);
        dch.Add(C);
        dch.Add(H);

        List<Point> eia = new List<Point>();
        eia.Add(E);
        eia.Add(I);
        eia.Add(A);
        eia.Add(B);

        Console.Write("fjg eia: ");
        Console.WriteLine(AvgClustDist(fjg, eia));
        Console.Write("dch eia: ");
        Console.WriteLine(AvgClustDist(dch, eia));
        Console.Write("fjg dch: ");
        Console.WriteLine(AvgClustDist(fjg, dch));

        //char[] points = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J' };
        //for (int i = 0; i < l.Count; i++)
        //{
        //    Console.WriteLine();
        //    for (int j = 0; j < l.Count; j++)
        //    {
        //        if (i == j) continue;
        //        Console.Write("dist ");
        //        Console.Write(points[i]);
        //        Console.Write(points[j]);
        //        Console.Write(" : ");
        //        Console.WriteLine(Dist(l[i], l[j]));
        //    }
        //}
    }

    public static double Dist(Point A, Point B)
    {
        return Math.Sqrt(Convert.ToDouble(Math.Pow((A.x - B.x), 2) + Math.Pow((A.y - B.y), 2)));
    }

    public static double AvgClustDist(List<Point> l1, List<Point> l2)
    {
        double sum_dist = 0.00;

        foreach (var p1 in l1)
        {
            foreach (var p2 in l2)
            {
                sum_dist += Dist(p1, p2);
            }
        }
        return (sum_dist / (l1.Count + l2.Count));
    }
}

class Point
{
    public int x;
    public int y;

    public Point(int x_, int y_)
    {
        this.x = x_;
        this.y = y_;
    }
}