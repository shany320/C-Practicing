using System.Globalization;

public class Program
{
    static void Main()
    {
        #region Q1 (Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.)
        //double x;
        //Console.WriteLine("Write a number that is divisible by 3 or 4");
        //double.TryParse(Console.ReadLine(),out x);
        //if (x % 4 == 0 || x % 3 == 0)
        //{
        //    Console.WriteLine("Yes");
        //}
        //else
        //{
        //    Console.WriteLine("No");
        //}
        #endregion
        #region Q2 (Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.)
        //double x;
        //Console.WriteLine("Enter a number");
        //double.TryParse(Console.ReadLine(), out x);
        //if (x>0)
        //{
        //    Console.WriteLine("You have entered a positive number");
        //}
        //else if (x==0)
        //{
        //    Console.WriteLine("You have entered a non positive or negative number");
        //}
        //else
        //{
        //    Console.WriteLine("You have entered a Negative number");
        //}
        #endregion
        #region Q3 (Write a program that takes 3 integers from the user then prints the max element and the min element.)
        //double[] x = new double[3];
        //Console.WriteLine("Enter three numbers");
        //for (int i = 0; i < x.Length; i++)
        //{
        //    double.TryParse(Console.ReadLine(), out x[i]);
        //}
        //Console.WriteLine($"The maximum number you have entered: {x.Max()}");
        //Console.WriteLine($"The minimum number you have entered: {x.Min()}");
        #endregion
        #region Q4 (Write a program that allows the user to insert an integer number then check If a number is even or odd.)
        //double x;
        //Console.WriteLine("Enter a number");
        //double.TryParse(Console.ReadLine(), out x);
        //if (x % 2 ==0)
        //{
        //    Console.WriteLine("You have entered an even number");
        //}
        //else if (x % 1 != 0 )
        //{
        //    Console.WriteLine("enter a whole integer");
        //}
        //else
        //{
        //    Console.WriteLine("You have entered an odd number");
        //}
        #endregion
        #region Q5 (Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).)
        //Console.WriteLine("Enter a character");
        //string?[] x = new string[1];
        //x[0]=Console.ReadLine();

        //if (x[0]=="a" || x[0] == "e" || x[0] == "i" || x[0] == "o" || x[0] == "u")
        //{
        //    Console.WriteLine("You have entered avowel character");
        //}
        //else if (double.TryParse(x[0],out double number)) 
        //{
        //    Console.WriteLine("Please enter a character");
        //}
        //else
        //{
        //    Console.WriteLine("You have entere a cosonant character");
        //}
        #endregion
        #region Q6 (Write a program that allows the user to insert an integer then print all numbers between 1 to that number.)
        //int x;
        //Console.WriteLine("Enter three numbers");
        //int.TryParse(Console.ReadLine(), out x);
        //for (int i = 1; i <= x; i++)
        //{
        //    Console.WriteLine(i);
        //}
        #endregion
        #region Q7 (Write a program that allows the user to insert an integer then print a multiplication table up to 12.)
        //int x;
        //Console.WriteLine("Enter a number");
        //int.TryParse(Console.ReadLine(), out x);
        //for (int i = 1; i <= 12; i++)
        //{
        //    Console.WriteLine(i*x);
        //}
        #endregion
        #region Q8 (Write a program that allows to user to insert number then print all even numbers between 1 to this number.)
        //int x;
        //Console.WriteLine("Enter a number");
        //int.TryParse(Console.ReadLine(), out x);
        //for (int i = 0; i<x; i+=2)
        //{
        //    Console.WriteLine(i);
        //}
        #endregion
        #region Q9 (Write a program that takes two integers then prints the power.)
        //Console.WriteLine("Enter a number");
        //int x;
        //int.TryParse(Console.ReadLine(), out x);
        //int y;
        //Console.WriteLine("Enter the value that is powered to the number");
        //int.TryParse(Console.ReadLine(), out y);
        //Console.WriteLine($"The value of the {x}^{y} is {Math.Pow(x,y)}");
        #endregion
        #region Q10 (Write a program to enter marks of five subjects and calculate total, average and percentage.)
        //Console.WriteLine("Please enter the value of the marks");
        //double?[] x = new double?[5];
        //double? marks = 0;
        //int validmarks = 0;
        //for (int i=0; i<x.Length; i++)
        //{
        //    Console.WriteLine($"Enter the total marks of student no.{i+1}");
        //    if (!double.TryParse(Console.ReadLine(), out double value)) 
        //    { Console.WriteLine($"The student no.{i + 1} has no marks and registered as absent ");
        //    }
        //    else 
        //    {
        //    x[i] = value;
        //    marks +=x[i];
        //    validmarks++;
        //    }
        //}
        //Console.WriteLine($"The total marks of the students is {marks} and the average value is {marks / validmarks}");
        #endregion
        #region Q11 ( Write a program to input the month number and print the number of days in that month.)
        //int monthnumber;
        //Console.WriteLine("Choose a month:\n1.Jan\n2.Feb\n3.Mar\n4.Apr\n5.May\n6.jun\n7.jul\n8.Aug\n9.Sep\n10.Oct\n11.Nov\n12.Dec");
        //if (!int.TryParse(Console.ReadLine(), out monthnumber))
        //{
        //    Console.WriteLine("Enter a number out of the list");
        //}
        //else if(monthnumber <= 0)
        //{
        //    Console.WriteLine("Enter a number out of the list");
        //}
        //else {
        //    switch (monthnumber) {
        //        case 2:
        //            Console.WriteLine("The month you chose has 28 days");
        //            break;
        //        case 6:
        //        case 4:
        //        case 9:
        //        case 11:
        //            Console.WriteLine("The month you chose has 30 days");
        //            break;

        //        default:
        //            Console.WriteLine("The month you chose has 31 days");
        //            break;
        //            }
        //}
        #endregion
        #region Q12 (Write a program to create a Simple Calculator.)
        //double x,y;
        //Console.WriteLine("Enter two numbers");
        //double.TryParse(Console.ReadLine(),out x);
        //double.TryParse(Console.ReadLine(), out y);
        //Console.WriteLine("Choose the operation you want for these two numbers:\n1.ADD\n2.Subtract\n3.Multiplication\n4.Division");
        //int.TryParse(Console.ReadLine(),out int value);
        //    switch (value)
        //    {
        //        case 1:
        //            Console.WriteLine($"The result is: {x+y}");
        //            break;
        //        case 2:
        //            if (x >= y)
        //            {
        //                Console.WriteLine($"The result is: {x - y}");

        //            }
        //            else 
        //            {
        //                Console.WriteLine($"The result is: {y - x}");
        //            }
        //                break;
        //         case 3:
        //            Console.WriteLine($"The result is: {x * y}");
        //            break;
        //          case 4:
        //            Console.WriteLine($"The result is: {x / y}");
        //            break;
        //        default:
        //            Console.WriteLine("Enter a value from the list");
        //            break;
        //    }

        #endregion
        #region Q13 (Write a program to allow the user to enter a string and print the REVERSE of it)
        //Console.WriteLine("enter the value of the string:");
        //string x = Console.ReadLine();
        //for (int i = x.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(x[i]);
        //}
        #endregion
        #region Q14 (Write a program to allow the user to enter int and print the REVERSED of it.)
        //Console.WriteLine("enter aseries of numbers:");
        //string x = Console.ReadLine();
        //for (int i = x.Length - 1; i >= 0; i--)
        //{
        //    Console.Write(x[i]);
        //}


        #endregion
        #region Q15 (Write a program in C# Sharp to find prime numbers within a range of numbers.) 
        //        Console.WriteLine("Enter a number to check if it is prime or not:");
        //        int x;

        //        if (!int.TryParse(Console.ReadLine(), out x))
        //        {
        //            Console.WriteLine("Invalid input. Please enter a valid number.");
        //            return;
        //        }

        //        if (x < 2)  // 0 and 1 are not prime
        //        {
        //            Console.WriteLine("This value is not a prime number. Please enter a number greater than one.");
        //            return;
        //        }

        //        bool isPrime = true;

        //        for (int i = 2; i * i <= x; i++)
        //        {
        //            if (x % i == 0)
        //            {
        //                isPrime = false;
        //                break; // Exit loop 
        //            }
        //        }

        //        if (isPrime)
        //            Console.WriteLine("The number is a prime number.");
        //        else
        //            Console.WriteLine("The number is not a prime number.");
        //    }
        //}

        // Program to check prime number in range of numbers
        //Console.WriteLine("Enter a the start number not less than 2:");
        //    int x;
        //    if (!int.TryParse(Console.ReadLine(), out x))
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid number.");
        //        return;
        //    }
        //    Console.WriteLine("Enter a the End number:");
        //    int y;
        //    if (!int.TryParse(Console.ReadLine(), out y))
        //    {
        //        Console.WriteLine("Invalid input. Please enter a valid number.");
        //        return;
        //    }
        //   if (x < 2) {
        //        Console.WriteLine("This start is less than the required. Please enter a number greater than one.");
        //        return;
        //    }
        //    Console.WriteLine("The prime numbers is");

        //    for(int j = x; j <= y; j++) 
        //    {
        //        bool isPrime = true;
        //        for (int i = 2; i * i <= j; i++)
        //        {
        //            if (j % i == 0)
        //            {
        //                isPrime = false;
        //                break; // Exit loop 
        //            }
        //        }

        //        if (isPrime)
        //        {
        //            //Console.WriteLine("The Prime numbers is");
        //            Console.Write(j + " ");
        //        }
        //    }
        //}




        #endregion
        #region Q16 ( Write a program in C# Sharp to convert a decimal number into binary without using an array) 
        //Console.WriteLine("Enter a decimal number:");
        //int x;
        //if (!int.TryParse(Console.ReadLine(),out x))
        //{
        //    Console.WriteLine("Enter a valid number");
        //}
        //string binary = "";
        //while (x > 0)
        //{
        //    binary = (x % 2) + binary;
        //    x = x / 2;
        //}
        //Console.WriteLine($"The binary value of the number is {binary}");
        #endregion
    }
}









