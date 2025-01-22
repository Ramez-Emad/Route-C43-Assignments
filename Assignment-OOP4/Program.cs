using Assignment_OOP4.Question_1;
using Assignment_OOP4.Question_2;
using Assignment_OOP4.Question_3;

namespace Assignment_OOP4
{


    internal class Program
    {

        static void Main(string[] args)
        {
            #region Part1

            // Q1 : b) To define a blueprint for a class  

            // Q2 : a) private

            // Q3 : c) Only if they are static

            // Q4 : b) Yes, interfaces can inherit from multiple interfaces

            // Q5 : d) implements

            // Q6 : a) Yes

            // Q7 : a) Yes, for all members

            // Q8 : b) To provide a clear separation between interface and class members

            // Q9 : d) Only if the constructor is static

            // Q10 : c) By separating interface names with commas

            #endregion

            #region Part2

            #region Q1
            //Circle circle = new Circle { Radius = 5 , Area = 32.4 };
            //circle.DisplayShapeInfo();
            //Console.WriteLine("--------------------------------------");
            //Rectangle rectangle = new Rectangle { Length = 10, Width = 4 , Area = 40.0};
            //rectangle.DisplayShapeInfo();
            #endregion

            #region Q2

            //BasicAuthenticationService Users = new BasicAuthenticationService();

            //Users.AddUser("Ramez", "password123", "admin");
            //Users.AddUser("Emad", "password456", "user");

            //IAuthenticationService authService = Users;


            //if (authService.AuthenticateUser("Ramez", "password123"))
            //{
            //    Console.WriteLine("User authenticated successfully!");
            //}
            //else
            //{
            //    Console.WriteLine("Authentication failed!");
            //}

            //if (authService.AuthorizeUser("Emad", "Admin"))
            //{
            //    Console.WriteLine("User authorized successfully!");
            //}
            //else
            //{
            //    Console.WriteLine("Authorization failed!");
            //}

            #endregion

            #region Q3

            //INotificationService emailService = new EmailNotificationService();
            //INotificationService smsService = new SmsNotificationService();
            //INotificationService pushService = new PushNotificationService();

            //emailService.SendNotification("Ramez Emad", "Hello, this is an email notification!");
            //smsService.SendNotification("+123456", "Hello, this is an SMS notification!");
            //pushService.SendNotification("Ramez Emad", "Hello, this is a push notification!");


            #endregion

            #endregion
        }
    }
}
