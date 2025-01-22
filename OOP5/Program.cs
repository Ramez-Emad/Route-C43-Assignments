using OOP5.First_Project;
using OOP5.Second_Project;
using OOP5.Third_Project;

namespace OOP5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region First Project

            //// Step 1: Create 3D Points using constructors
            //Point3D P1 = new Point3D(10, 10, 10);
            //Console.WriteLine(P1.ToString());

            //// Step 3: Read coordinates for two points P1 and P2
            //Console.WriteLine("Enter coordinates for Point 1:");
            //P1 = Point3D.ReadPoint();

            //Console.WriteLine("Enter coordinates for Point 2:");
            //Point3D P2 = Point3D.ReadPoint();

            //// Step 4: Compare P1 and P2 using ==
            //Console.WriteLine($"P1: {P1}");
            //Console.WriteLine($"P2: {P2}");
            //Console.WriteLine($"Are P1 and P2 equal? {P1 == P2}");

            //Point3D[] points = new Point3D[]
            //{
            //new Point3D(5, 2, 3),
            //new Point3D(1, 3, 4),
            //new Point3D(2, 2, 2),
            //new Point3D(3, 1, 1)
            //};

            //Array.Sort(points);

            //Console.WriteLine("Sorted Points based on X and Y:");
            //foreach (var point in points)
            //{
            //    Console.WriteLine(point);
            //}

            //// Step 6: Clone a point
            //Point3D clonedPoint = (Point3D)P1.Clone();
            //Console.WriteLine($"Cloned Point: {clonedPoint}");

            //// Modify the cloned point and check original remains unchanged
            //clonedPoint.x = 50;
            //Console.WriteLine($"Modified Cloned Point: {clonedPoint}");
            //Console.WriteLine($"Original Point after modifying clone: {P1}");

            # endregion

            #region Second Project

            //Console.WriteLine($"Addition: {Maths.Add(10, 20)}");
            //Console.WriteLine($"Subtraction: {Maths.Subtract(50, 20)}");
            //Console.WriteLine($"Multiplication: {Maths.Multiply(5, 4)}");
            //Console.WriteLine($"Division: {Maths.Divide(100, 5)}");
            //Console.WriteLine("------------------------");
            //Console.WriteLine(value: $"Division by zero test: {Maths.Divide(10, 0)}");

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

            #endregion
        }
    }
}
