using C_OOP_Assignment03.Part02;
using C_OOP_Assignment03.Part02.Q2;
using C_OOP_Assignment03.Part02.Q3;
#region Q2
enum Userrole { Admin,User,Guest}
#endregion


class Program
{
    static void Main()
    {
        #region Part 01
        #region Q1 
        //Q1) What is the primary purpose of an interface in C#?
        //Answer: (b) To define a blueprint for a class
        #endregion
        #region Q2 
        //Q2) Which of the following is NOT a valid access modifier for interface members in C#?
        //Answer: (a) Private
        #endregion
        #region Q3 
        //Q3) Can an interface contain fields in C#?
        //Answer: (c) Only if they are static
        #endregion
        #region Q4
        //Q4)In C#, can an interface inherit from another interface?
        //Answer: (b) Yes, interfaces can inherit from multiple interfaces
        #endregion
        #region Q5
        //Q5) Which keyword is used to implement an interface in a class in C#?
        //Answer: (d) implements
        #endregion
        #region Q6
        //Q6) Can an interface contain static methods in C#?
        //Answer: (a) Yes
        #endregion
        #region Q7
        //Q7) Can an interface contain static methods in C#?
        //Answer: (a) Yes
        #endregion
        #region Q8
        //Q8) What is the purpose of an explicit interface implementation in C#?
        //Answer: (b) To provide a clear separation between interface and class members
        #endregion
        #region Q9
        //Q9) In C#, can an interface have a constructor?
        //Answer: d) Only if the constructor is static
        #endregion
        #region Q10
        //Q10) How can a C# class implement multiple interfaces?
        //Answer: (c) By separating interface names with commas
        #endregion
        #endregion
        #region Part 02
        #region Question 01
        //For Circle
        Circle C01 = new Circle() { radius = 3 };
        Icircle C = C01;
        C.display_shape_info();

        //For Rectangle
        Rectangle R01 = new Rectangle() { length = 3, width = 5 };
        Irectangle R = R01;
        R.display_shape_info();
        #endregion
        #region Question 02
        //Iauthentication_service emp01 = new Basic_authentication_service();
        //Console.WriteLine("Enter the username:");
        //string username = Console.ReadLine();
        //Console.WriteLine("Enter the password:");
        //string Password = Console.ReadLine();
        //if (emp01.Authenticate_user(username, Password))
        //{
        //    Console.WriteLine("User Authenticated Successfully");
        //    Console.WriteLine("Enter the role (1.admin , 2.User , 3.Guest)");
        //    int x;
        //    while (!int.TryParse(Console.ReadLine(), out x))
        //    { Console.WriteLine("Enter a valid number"); }
        //    switch (x)
        //    {
        //        case 1:
        //            if (emp01.Authorize_user(username, Userrole.Admin))
        //            { Console.WriteLine("Authorization role successfully accessed"); }
        //            else
        //            { Console.WriteLine("\"Authorization role failed to be accessed"); }
        //            break;
        //        case 2:
        //            if (emp01.Authorize_user(username, Userrole.User))
        //            { Console.WriteLine("Authorization role successfully accessed"); }
        //            else
        //            { Console.WriteLine("\"Authorization role failed to be accessed"); }
        //            break;
        //        case 3:
        //            if (emp01.Authorize_user(username, Userrole.Guest))
        //            { Console.WriteLine("Authorization role successfully accessed"); }
        //            else
        //            { Console.WriteLine("\"Authorization role failed to be accessed"); }
        //            break;
        //        default:
        //            { Console.WriteLine("The user you entered has no authorization access"); }
        //            break;
        //    }
        //}
        //else { Console.WriteLine("The user is not found"); }
        #endregion
        #region Question 03
        //Inotification_service recipient01 = new Email_Notification_Service();
        //recipient01.Send_notification("Ahmed", "Hello Ahmed");
        //Inotification_service recipient02 = new SMS_Notification_Service();
        //recipient02.Send_notification("Omar", "Hello Omar");
        //Inotification_service recipient03 = new Push_Notification_Service();
        //recipient03.Send_notification("Saif", "Hello Saif");

        #endregion
        #endregion

    }

}

