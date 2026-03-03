using System;
using System.Collections.Generic;

class ConvexHull
{
    struct Point { public int x, y; }

    static int Orientation(Point p, Point q, Point r)
    {
        return (q.y - p.y) * (r.x - q.x) -
               (q.x - p.x) * (r.y - q.y);
    }

    static void Main()
    {
        Point[] points = {
            new Point{x=0,y=3},
            new Point{x=2,y=2},
            new Point{x=1,y=1},
            new Point{x=2,y=1},
            new Point{x=3,y=0},
            new Point{x=0,y=0},
            new Point{x=3,y=3}
        };

        int n = points.Length;
        int l = 0;
        for (int i = 1; i < n; i++)
            if (points[i].x < points[l].x)
                l = i;

        int p = l, q;
        do
        {
            Console.WriteLine(points[p].x + "," + points[p].y);
            q = (p + 1) % n;
            for (int i = 0; i < n; i++)
                if (Orientation(points[p], points[i], points[q]) < 0)
                    q = i;
            p = q;
        } while (p != l);
    }
}