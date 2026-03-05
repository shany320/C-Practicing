using C_OOP_Assignment01.Assignment_2;
using System;
using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Reflection;
using System.Reflection.Emit;
using System.Transactions;
using System.Xml.Linq;
using System.Xml.Schema;
using static System.Net.Mime.MediaTypeNames;

class Program {
    #region(1) 	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
    enum Weekdays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }  // enum should be dec;ared at the class level not inside a method static void main()
    #endregion
    #region (3) 3.	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
    enum Season { Spring, Summer, Autmn, Winter }
    public static String SeasonMonth(int Number)
    {
        int index;
        if (Number >= 3 && Number <= 5)
        {
            index = 0;
        }
        else if (Number >= 6 && Number <= 8)
        {
            index = 1;

        }
        else if (Number >= 9 && Number <= 11)
        {
            index = 2;

        }
        else if (Number == 12 || Number <= 2)
        {
            index = 3;

        }
        else return "Not Valid";
        return ((Season)index).ToString();

    }
    #endregion
    #region (4)  Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
    [Flags]
    enum Permissions { Add = 1, Read = 2, Delete = 4, Execute = 8 }
    #endregion
    #region (5)  Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
    enum Colors { Red , Green , Blue }
    #endregion

    static void Main()
    {
        #region(1) 	Create an enum called "WeekDays" with the days of the week (Monday to Sunday) as its members. Then, write a C# program that prints out all the days of the week using this enum.
        //foreach (Weekdays x in Enum.GetValues(typeof(Weekdays)))
        //{ Console.WriteLine(x); }
        //Weekdays z = Weekdays.Monday;
        #endregion
        #region (2)	Define a struct "Person" with properties "Name" and "Age". Create an array of three "Person" objects and populate it with data. Then, write a C# program to display the details of all the persons in the array.
        //Person[] p01 = {
        //  new Person("ahmed", 21),
        //  new Person("saif", 25),
        //  new Person("Moataz", 30)};

        //    foreach (Person x in p01)
        //    { Console.WriteLine($"Name:{x.name},Age:{ x.age}"); }
        #endregion
        #region (3)	Create an enum called "Season" with the four seasons (Spring, Summer, Autumn, Winter) as its members. Write a C# program that takes a season name as input from the user and displays the corresponding month range for that season. Note range for seasons ( spring march to may , summer june to august , autumn September to November , winter December to February)
        //Console.WriteLine("enter a number of month in the year {1-12}");
        //int month;
        //while(!int.TryParse(Console.ReadLine(),out month))
        //{ 
        //   Console.WriteLine("Enter a valid data");
        //}
        //Console.WriteLine($"Season: {SeasonMonth(month)}");
        #endregion
        #region (4)  Assign the following Permissions (Read, write, Delete, Execute) in a form of Enum.Create Variable from previous Enum to Add and Remove Permission from variable, check if specific Permission is existed inside variable
        //Permissions Userpermission01 = Permissions.Add;
        //Userpermission01 ^= Permissions.Read;
        //Userpermission01 |= Permissions.Delete;
        //if ((Userpermission01 & Permissions.Execute) == Permissions.Execute)
        //{ Console.WriteLine("Permissions is Found"); }
        //else { Console.WriteLine("Permissions is not Found"); }
        #endregion
        #region (5)  Create an enum called "Colors" with the basic colors (Red, Green, Blue) as its members. Write a C# program that takes a color name as input from the user and displays a message indicating whether the input color is a primary color or not.
        //Console.WriteLine("Enter a color:");
        //if(Enum.TryParse(Console.ReadLine(),true/* Makes it Case sensitive */, out Colors selectedcolor))
        //{ Console.WriteLine("This is a primary Color"); }
        //else { Console.WriteLine("This is a Secondary Color"); }
        #endregion
        #region (6) Create a struct called "Point" to represent a 2D point with properties "X" and "Y". Write a C# program that takes two points as input from the user and calculates the distance between them.
        //MyPoint[] p01 = new MyPoint[2];

        //for (int i = 0; i < 2; i++)
        //{
        //    Console.WriteLine($"Enter the Coordinates of Point {i + 1}:");

        //    int x, y;

        //    Console.Write("X: ");
        //    while (!int.TryParse(Console.ReadLine(), out x))
        //        Console.WriteLine("Enter a valid number");

        //    Console.Write("Y: ");
        //    while (!int.TryParse(Console.ReadLine(), out y))
        //        Console.WriteLine("Enter a valid number");


        //    p01[i] = new MyPoint(x, y);
        //}
        //if (p01[0].x == p01[1].x)
        //{
        //    Console.WriteLine("The points have the same x-coordinate. Distance calculation is invalid.");
        //    return;
        //}
        //double distance = Math.Sqrt(Math.Pow(p01[1].x - p01[0].x, 2) + Math.Pow(p01[1].y - p01[0].y, 2));
        //Console.WriteLine($"The distance between the two points:{distance}");
        #endregion
        #region (7) Create a struct called "Person" with properties "Name" and "Age". Write a C# program that takes details of 3 persons as input from the user and displays the name and age of the oldest person.
        // Person[] persons = new Person[3]; 
        // for (int i=0;i<3;i++)
        // {
        //     Console.WriteLine("Enter the name of the person");
        //     string name;
        //     while(string.IsNullOrWhiteSpace(name=Console.ReadLine())) 
        //     {
        //         Console.WriteLine("Enter a valid value"); 
        //     }
        //     Console.WriteLine("Enter the age of the person");
        //     int age;
        //     while (!int.TryParse(Console.ReadLine(),out age))
        //     {
        //         Console.WriteLine("Enter a valid value");
        //     }
        //     persons[i].name = name;
        //     persons[i].age = age;
        // }
        //if (persons[0].age > persons[1].age)
        // { 
        //     if (persons[0].age > persons[2].age) { Console.WriteLine($"The Oldest person is {persons[0].name} with age {persons[0].age}"); }
        //     else { Console.WriteLine($"The Oldest person is {persons[2].name} with age {persons[2].age}"); }
        // }
        //else if (persons[1].age > persons[2].age) 
        // {
        //     Console.WriteLine($"The Oldest person is {persons[1].name} with age {persons[1].age}");
        // }
        // else { Console.WriteLine($"The Oldest person is {persons[2].name} with age {persons[2].age}"); }
        #endregion
        #region Encapsulation (1) Design and implement a Class for the employees in a company: Employee is identified by an ID, Name, security level, salary, hire date and Gender.
        //Employee emp01 = new Employee(01,"Saif Hany",12353213,10000,new DateOnly(2020, 5, 10),"Male");
        //emp01.printemployee();
        #endregion
        #region Encapsulation (2) Develop a Class to represent the Hiring Date Data:consisting of fields to hold the day, month and Years.
        //Hiringdate date01 = new Hiringdate(21, 3, 2012);
        //date01.printhiredate();
        //Employeee emp01 = new Employeee(01, "Saif Hany", 12353213, 10000, new Hiringdate(21,3,2000), "Male");
        //emp01.printemployeee();
        #endregion
        #region Encapsulation (3)  We need to restrict the Gender field to be only M or F [Male or Female] 
        //Employeee emp01 = new Employeee(01, "Saif Hany", 12353213, 10000, new Hiringdate(21, 3, 2000), 'Y');
        //emp01.printemployeee();
        #endregion
        #region Encapsulation (4 & 5) Assign the following security privileges to the employee (guest, Developer, secretary and DBA) in a form of Enum
        //Employeee emp01 = new Employeee(01, "Saif Hany", Previliges.Guest , 10000, new Hiringdate(21, 3, 2000), 'M');
        //Console.WriteLine(emp01.ToString()); 
        #endregion
        #region encapsulation (6) Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
        //Employeee[] EmpArr = new Employeee[3];

        //EmpArr[0] = new Employeee(01, "Alice", Previliges.DBA, 12000, new Hiringdate(10, 5, 2015), 'F');
        //EmpArr[1] = new Employeee(02, "Bob", Previliges.Guest, 5000, new Hiringdate(22, 8, 2018), 'M');
        //EmpArr[2] = new Employeee(03, "Charlie", Previliges.SecurityOfficer, 15000, new Hiringdate(1, 1, 2020), 'M');

        //foreach (var emp in EmpArr)
        //{
        //    Console.WriteLine(emp);
        //}
        #endregion
    }
}

