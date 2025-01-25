namespace OOP1
{

    internal class Program
    {
      
        #region Q1
        enum WeekDays
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        #endregion

        #region Q2
        enum Seasons
        {
            Spring,
            Summer,
            Autumn,
            Winter
        }
        #endregion

        #region Q3
        [Flags]
        enum Permissions
        {
            None = 0,
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }
        #endregion

        #region Q4
        enum Colors
        {
            Red,
            Green,
            Blue
        }
        #endregion
        static void Main()
        {
            #region P2-Q1

            // Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.

            //Console.WriteLine("Days of the Week:");
            //foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            //{
            //    Console.WriteLine(day); 
            //}

            #endregion

            #region P2-Q2
            //3.Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)

            //Console.WriteLine("Enter a season name (Spring, Summer, Autumn, Winter):");
            //string input = Console.ReadLine();


            //if (Enum.TryParse(input, true, out Seasons season))
            //{
            //    switch (season)
            //    {
            //        case Seasons.Spring:
            //            Console.WriteLine("Spring: March to May");
            //            break;
            //        case Seasons.Summer:
            //            Console.WriteLine("Summer: June to August");
            //            break;
            //        case Seasons.Autumn:
            //            Console.WriteLine("Autumn: September to November");
            //            break;
            //        case Seasons.Winter:
            //            Console.WriteLine("Winter: December to February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Please enter a valid season name.");
            //}

            #endregion

            #region P2-Q3

            //Permissions userPermissions = Permissions.None;

            //userPermissions |= Permissions.Read;
            //userPermissions |= Permissions.Write;

            //Console.WriteLine($"Current Permissions: {userPermissions}");

            //Console.WriteLine("Check if Write permission exists:");
            //bool hasWritePermission = (userPermissions & Permissions.Write) == Permissions.Write;
            //Console.WriteLine(hasWritePermission ? "Write permission exists." : "Write permission does not exist.");

            //Console.WriteLine("Removing Write permission...");
            //userPermissions &= ~Permissions.Write;

            //Console.WriteLine($"Current Permissions: {userPermissions}");

            //Console.WriteLine("Check if Write permission exists after removal:");
            //hasWritePermission = (userPermissions & Permissions.Write) == Permissions.Write;
            //Console.WriteLine(hasWritePermission ? "Write permission exists." : "Write permission does not exist.");

            #endregion

            #region P2-Q4
            //4. Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.

            //Console.WriteLine("Enter a color name (e.g., Red, Green, Blue):");
            //string input = Console.ReadLine();

            //// Check if the input color is a primary color
            //if (Enum.TryParse(input, true, out Colors color))
            //{
            //    Console.WriteLine($"{color} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{input} is not a primary color.");
            //}

            #endregion

        }
    }
}