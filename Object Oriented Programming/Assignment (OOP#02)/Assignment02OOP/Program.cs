using Assignment02OOP;
using Assignment02OOP._2nd_Project;
using Assignment02OOP.Third_Project;
using System.Transactions;

class Program
{
    static void Main()
    {
        #region First Project
        #region Create the class
        //ThreeDPoint p01 = new ThreeDPoint();
        //ThreeDPoint p02 = new ThreeDPoint(12, 40);
        //ThreeDPoint p03 = new ThreeDPoint(12, 40, 70);
        #endregion
        #region print the point by overriding the to string
        //Console.WriteLine(p03.ToString());
        #endregion
        #region read two points from the user
        //ThreeDPoint[] points = new ThreeDPoint[2];
        //int x, y, z;
        //for (int i = 0; i < points.Length; i++)
        //{
        //    Console.WriteLine($"Enter X-Coordinates for point no.({i + 1})");
        //    while (!int.TryParse(Console.ReadLine(), out x)) { Console.WriteLine("Enter a valid number"); }
        //    Console.WriteLine($"Enter Y-Coordinates for point no.({i + 1})");
        //    while (!int.TryParse(Console.ReadLine(), out y)) { Console.WriteLine("Enter a valid number"); }
        //    Console.WriteLine($"Enter Z-Coordinates for point no.({i + 1})");
        //    while (!int.TryParse(Console.ReadLine(), out z)) { Console.WriteLine("Enter a valid number"); }
        //    points[i] = new ThreeDPoint(x, y, z);
        //}
        //foreach (var p in points)
        //{ Console.WriteLine(p.ToString()); }
        #endregion
        #region check if (p1==p2) works properly
        //if (points[0] == points[1]) { Console.WriteLine("The two points are equal"); }
        //else { Console.WriteLine("The two points are not equal"); }
        #endregion
        #region Sort thearray according to the X-Coordinates
        //Array.Sort(points);
        //foreach (ThreeDPoint p in points)
        //{ Console.WriteLine(p.ToString()); }
        #endregion
        #region Cloning the object
        //ThreeDPoint clone01 =(ThreeDPoint) points[0].Clone();
        #endregion
        #endregion
        #region Second Project
        //Console.WriteLine(Mymath.add(1, 2));
        //Console.WriteLine(Mymath.subtract(1, 2));
        //Console.WriteLine(Mymath.multiply(1, 2));
        //Console.WriteLine(Mymath.divide(1, 2));
        #endregion
        #region Third Project
        //Duration D1 = new Duration(1, 10, 15);
        //Console.WriteLine(D1.ToString());
        //Duration D2 = new Duration(3600);
        //Console.WriteLine(D2.ToString());
        //Duration D3 = new Duration(7800);
        //Console.WriteLine(D3.ToString());
        //Duration D4 = new Duration(666);
        //Console.WriteLine(D4.ToString());
        #region operator overloading
        //Duration D3 = D1 + D2;
        //Console.WriteLine(D3);

        //D3 = D1 + 7800;
        //Console.WriteLine(D3);

        //D3 = 666 + D3;
        //Console.WriteLine(D3);

        //D3 = ++D1;
        //Console.WriteLine(D3);

        //D3 = --D2;
        //Console.WriteLine(D3);

        //D1 = D1 - D2;
        //Console.WriteLine(D1);

        //Console.WriteLine(D1 > D2);
        //Console.WriteLine(D1 <= D2);
        //if (D1)
        //{
        //    Console.WriteLine("D1 is a valid");
        //}
        //else
        //{
        //    Console.WriteLine("D1 is zero.");
        //}

        //DateTime dt = (DateTime)D1;
        //Console.WriteLine(dt);
        #endregion
        #endregion
    }
}
