namespace OOP06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duration D1 = new Duration(1, 10, 15);
            Console.WriteLine(D1.ToString());

            Duration D2 = new Duration(3600);
            Console.WriteLine(D2.ToString()); 

            Duration D3 = new Duration(7800);
            Console.WriteLine(D3.ToString()); 

            Duration D4 = new Duration(666);
            Console.WriteLine(D4.ToString());

            Console.WriteLine("-------------------------------");

            Duration D5 = D1 + D2;
            Console.WriteLine(D5.ToString()); 

            D5 = D1 + 7800;
            Console.WriteLine(D5.ToString());

            D5 = 666 + D4;
            Console.WriteLine(D5.ToString());

            D5 = ++D1;
            Console.WriteLine(D5.ToString()); 

            D5 = --D2;
            Console.WriteLine(D5.ToString()); 

            D1 = D1 - D2;
            Console.WriteLine(D1.ToString());

            Console.WriteLine("-------------------------------");

            if (D1 > D2)
            {
                Console.WriteLine("D1 is greater than D2");
            }
            else if (D1 <= D2)
            {
                Console.WriteLine("D1 is less than or equal to D2");
            }

            if (D1)
            {
                Console.WriteLine("D1 is non-zero");
            }
            else
            {
                Console.WriteLine("D1 is zero");
            }
            Console.WriteLine("-------------------------------");

            DateTime Obj = (DateTime)D1;
            Console.WriteLine($"DateTime: {Obj.ToString("HH:mm:ss")}");
        }
    }
}
