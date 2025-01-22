using System.Drawing;

namespace OOP5.First_Project
{
    internal class Point3D : IComparable , ICloneable
    {

        #region Attributes

        private int _x;
        private int _y;
        private int _z;

        #endregion

        #region Properties

        public int x
        {
            get { return _x; }
            set { _x = value; }
        }


        public int y
        {
            get { return _y; }
            set { _y = value; }
        }

        public int z
        {
            get { return _z; }
            set { _z = value; }
        }

        #endregion

        #region Constructors
        public Point3D(int _x, int _y, int _z)
        {
            this._x = _x;
            this._y = _y;
            this._z = _z;
        }
        public Point3D(int _x, int _y) : this(_x, _y, 0) { }
        public Point3D(int _x) : this(_x, 0, 0) { }
        public Point3D() : this(0, 0, 0) { }
        public Point3D(Point3D other)
        {
            if (other != null)
            {
               _x = other._x;
               _y = other._y;
               _z = other._z;
            }
        }
        #endregion

        public override string ToString()
        {
            return $"Point Coordinates: ({x}, {y}, {z}).";
        }

        public static Point3D ReadPoint()
        {
            Point3D _3DPoint = new Point3D();
            do
            {
                Console.Write($"Enter First Dimension: ");

            } while (!int.TryParse(Console.ReadLine(),  out _3DPoint._x ));

            do
            {
                Console.Write($"Enter Second Dimension: ");

            } while (!int.TryParse(Console.ReadLine(), out _3DPoint._y));

            do
            {
                Console.Write($"Enter Third Dimension: ");

            } while (!int.TryParse(Console.ReadLine(), out _3DPoint._z));

            Console.WriteLine("----------------------------------------");
            return _3DPoint;
        }

        public int CompareTo(object? obj)
        {

            if (obj is Point3D otherPoint)
            {
                int xComparison = x.CompareTo(otherPoint.x);
                if (xComparison != 0)
                    return xComparison;

                int yComparison = y.CompareTo(otherPoint.y);
                if (yComparison != 0)
                    return yComparison;

                return z.CompareTo(otherPoint.z);
            }
            else
                return -1;
        }

        public object Clone()
        {
            return new Point3D(this);
        }


        public override bool Equals(object? obj)
        {
            if (obj is Point3D other)
            {
                return _x == other._x && _y == other._y && _z == other._z;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(_x, _y, _z);
        }

        public static bool operator ==(Point3D left, Point3D right)
        {
            if (ReferenceEquals(left, right)) return true;
            if (left is null || right is null) return false;
            return left.Equals(right);
        }
        public static bool operator !=(Point3D left, Point3D right)
        {
            return !(left == right);
        }
    }
}
