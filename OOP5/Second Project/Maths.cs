namespace OOP5.Second_Project
{
    public static class Maths
    {
        public static int Add( int x , int y)
        {
            return x + y;
        }

        public static int Subtract( int x , int y )
        {
           return ( x - y );
        }

        public static int Multiply( int x , int y ) {  return x * y; }

        public static int Divide( int x , int y ) { 
            if ( y == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return 0;
            }
            return x / y;
        }
    }
}
