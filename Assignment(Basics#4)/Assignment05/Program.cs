using System.Collections.Immutable;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;

public class Program {
    #region (Q2) (Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.)
    static int SumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }
        Console.WriteLine($"The sum of the digits is {sum}");
        return sum;
    }
    #endregion 
    #region (Q3) ( Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not .)
    static int Isprime(int num)
    {
        int i = 2;
        if (num < 2) return 0;

        else
        {
            do
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine("The number is not prime number");
                    return -1;
                }
                i++;
            } while (i < num * num);
            Console.WriteLine("The number is prime number");
            return 1;

        }
    }
    #endregion
    #region Q28 (The difference between passing by value and passing by difference)
    static void PassByValue(int num)
        {           
            num = num * 2;  // Modifies the local copy
            Console.WriteLine("Inside PassByValue: " + num);
        }

       // Method that takes a value type parameter by reference using 'ref'
        static void PassByReference(ref int num)
        {
        num = num * 2;  // Modifies the actual variable
        Console.WriteLine("Inside PassByReference: " + num);
        }
    #endregion
    #region (Q4) (Create an iterative (non-recursive) function to calculate the factorial of the number specified as parameter)
    static int factorial(int x)
    {
        int factor = 1;
        for (int i = x; i > 0; i--)
        {
            factor *= i;
        }
        Console.WriteLine($"The factorial product of the number you inserted = {factor}");
        return factor;
    }
    #endregion
    static void changechar(char[] x)
    {

        char temp = x[3] ;
        x[3]= x[0];
        x[0] = temp;
        foreach (char c in x) { Console.Write(c); }

    }
    public static void Main()
    {
        #region (Q19) (Create a program to specidy the size of identity matrix by inserting an input "n")
        //Console.WriteLine("Enter the size of array");
        //int.TryParse(Console.ReadLine(), out int n);
        //int[,] rect = new int[n, n];
        //for (int i = 0; i < rect.GetLength(0); i++) 
        //{
        //    for(int j = 0; j < rect.GetLength(1); j++) 
        //    {
        //        Console.Write(rect[i,j]+" ");
        //    }
        //    Console.WriteLine();//it add line between rows like \n
        //}
        #endregion
        #region (Q20) (Write a program in C# Sharp to find the sum of all elements of the array.)
        //Console.WriteLine("Enter the length of the array");
        //int n;
        //while(!int.TryParse(Console.ReadLine(), out n)) { Console.WriteLine("Enter a valid number"); }
        //int[] x = new int[n];
        //for(int i=0; i<x.Length; i++)
        //{
        //    Console.WriteLine($"Enter the value number ({i+1}):");
        //    while(!int.TryParse(Console.ReadLine(), out x[i])) 
        //    { 
        //        Console.WriteLine("Enter a valid number");
        //        Console.WriteLine($"Enter the value number ({i + 1}):");
        //    }   
        //}
        //int sum = x.Sum();
        //Console.WriteLine($"The summation of array elements is {sum}");
        #endregion
        #region (Q21) (Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order.)
        //int n;
        //Console.WriteLine($"Enter the size of the arrays:");
        //while (!int.TryParse(Console.ReadLine(),out n)) { Console.WriteLine("Enter a valid number"); }
        //int[] arr01 = new int[n];
        //int[] arr02 = new int[n];
        //int[] arr03 = new int[2 * n];
        //for (int i = 0; i < 2 * n; i++)
        //{
        //    if (i < arr01.Length) // here is to insert the array 01 and assign it to array 03
        //    {
        //        Console.WriteLine($"Enter the arr01 element value number ({i + 1}):");
        //        while (!int.TryParse(Console.ReadLine(), out arr01[i])) // while is for checking if the input is a number 
        //        {
        //            Console.WriteLine("Enter a valid number");
        //            Console.WriteLine($"Enter the arr01 element value number ({i + 1}):");
        //        }
        //        arr03[i] = arr01[i];
        //    }
        //    else // here is to insert the array 02 and assign it to array 03
        //    {
        //        Console.WriteLine($"Enter the arr02 element value number ({i - n + 1}):"); //remaindering i by n to reset index number from the beginning 
        //        while (!int.TryParse(Console.ReadLine(), out arr02[i-n]))
        //       {
        //            Console.WriteLine("Enter a valid number");
        //            Console.WriteLine($"Enter the arr02 element value number ({i -n+ 1}):");
        //       }
        //        arr03[i] = arr02[i - n];
        //    }
        //}
        //Array.Sort(arr03); //sorting the new array
        //foreach (int num in arr03) // Print sorted array
        //{
        //    Console.Write(num + " "); 
        //}
        #endregion
        #region (Q22) (Write a program in C# Sharp to count the frequency of each element of an array)
        //int[] numbers = { 1, 2, 2, 3, 3, 3, 4, 5, 5 };

        //for (int i = 0; i < numbers.Length; i++)
        //{
        //    int count = 1; // Count the current number
        //    bool alreadyCounted = false;
        //    #region (check if the number is counted before (look at the previous numbers if is equal to the index number i))
        //    // Check if this number was counted before
        //    for (int k = 0; k < i; k++)
        //    {
        //        if (numbers[k] == numbers[i])
        //        {
        //            alreadyCounted = true;
        //            break;
        //        }
        //    }

        //    if (alreadyCounted)
        //        continue; // Skip the main iteration of (i) if already counted
        //    #endregion
        //    #region(here it looks to the perceeding numbers if it does equal to the index number (i) so it counts +1)
        //    // Count occurrences of numbers[i]
        //    for (int j = i + 1; j < numbers.Length; j++)
        //    {
        //        if (numbers[j] == numbers[i])
        //        {
        //            count++;
        //        }
        //    }
        //    #endregion

        //    Console.WriteLine($"{numbers[i]}: {count}");
        //}
        //(((((((((((((((((((((((code by me)))))))))))))))))))))))))) 
        //int[] numbers = { 1, 1, 2, 3, 3, 3, 4,4,5};
        //for (int i =0; i < numbers.Length; i++) 
        //{
        //    int count = 1;
        //    bool counted = false;
        //    for (int y = 0; y < i; y++) 
        //    {
        //        if (numbers[y] == numbers[i]) 
        //           {
        //            counted = true;
        //            break;
        //        }
        //    }
        //    if (counted)
        //        continue;
        //    for (int j = i + 1; j < numbers.Length; j++) 
        //    {
        //        if (numbers[j] == numbers[i])
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine($"{numbers[i]}: {count}");


        //}
        #endregion
        #region(Q23)( Write a program in C# Sharp to find maximum and minimum element in an array)
        //Console.WriteLine("Enter the size of the array");
        //int n;
        //while(!int.TryParse(Console.ReadLine(), out n)){ Console.WriteLine("Enter a valid number"); }
        //int[] arr01 = new int[n];
        //for(int i = 0; i < arr01.Length; i++)
        //{
        //    Console.WriteLine($"Enter the value number ({i + 1}):");
        //    while (!int.TryParse(Console.ReadLine(), out arr01[i]))
        //    {
        //        Console.WriteLine("Enter a valid number");
        //        Console.WriteLine($"Enter the value number ({i + 1}):");
        //    }
        //}
        //Array.Sort(arr01);
        //Console.WriteLine($"The maximum number is {arr01[n - 1]} and the minimum is {arr01[0]}");
        #endregion
        #region(Q24)(Write a program in C# Sharp to find the second largest element in an array.)
        //Console.WriteLine("Enter the size of the array");
        //int n;
        //while (!int.TryParse(Console.ReadLine(), out n)) { Console.WriteLine("Enter a valid number"); }
        //int[] arr01 = new int[n];
        //for (int i = 0; i < arr01.Length; i++)
        //{
        //    Console.WriteLine($"Enter the value number ({i + 1}):");
        //    while (!int.TryParse(Console.ReadLine(), out arr01[i]))
        //    {
        //        Console.WriteLine("Enter a valid number");
        //        Console.WriteLine($"Enter the value number ({i + 1}):");
        //    }
        //}
        //Array.Sort(arr01);
        //Console.WriteLine($"The Second largest number in the array is {arr01[n - 2]}");
        #endregion
        #region (Q25)(Write a program in C# Sharp to find the second smallest element in an array.)
        //Console.WriteLine("Enter a sentence");
        //string sentence = Console.ReadLine();
        //string[] words = sentence.Split(' ');
        //Array.Reverse(words);
        //foreach (string word in words) 
        //{ Console.Write(word+" "); }
        #endregion
        #region (Q26)(Write a program to create two multidimensional arrays of same size. Accept value from user and store them in first array. Now copy all the elements of first array on second array and print second array.)
        //int n,m;
        //Console.WriteLine("Enter the number of rows");
        //int.TryParse(Console.ReadLine(), out n);
        //Console.WriteLine("Enter the number of columns");
        //int.TryParse(Console.ReadLine(), out m);
        //int[,] arr01 = new int[n, m];
        //int[,] arr02 = new int[n, m];
        //for (int i = 0; i < arr01.GetLength(0); i++) 
        //{
        //    Console.WriteLine($"For row no.{i}");
        //    for(int j = 0; j < arr01.GetLength(1); j++)
        //    {
        //        Console.WriteLine($"Enter the value for column no.{j}");
        //        while (!int.TryParse(Console.ReadLine(), out arr01[i, j]))
        //        {
        //            Console.WriteLine("Enter a valid number");
        //            Console.WriteLine($"Enter the value for column no.{j}");
        //        }
        //        arr02[i, j] = arr01[i, j];
        //    }
        //}
        //for (int i =0; i < arr02.GetLength(0); i++)
        //{
        //    for (int j = 0; j < arr02.GetLength(1); j++)
        //    {
        //        Console.Write(arr02[i, j] + " ");
        //    }
        //    Console.WriteLine();
        //}
        #endregion
        #region (Q27)(Write a Program to Print One Dimensional Array in Reverse Order)
        //int[] numbers = { 1, 2, 3, 4, 5 };
        //Array.Reverse(numbers);
        //foreach(int num in numbers)
        //{
        //    Console.Write(num + " ");
        //}
        #endregion
        //////////////////////////////////////////////////////////////////////// FUNCTIONS///////////////////////////////////////////////////////////////////
        #region(Q1) (The difference between passing by value and passing by difference)
        //int x = 10;
        //PassByValue(x);
        //Console.WriteLine($"pass by value: {x}"); // x is still 10
        //PassByReference(ref x);
        //Console.WriteLine($"pass by reference:{x}"); // x is now 20
        #endregion
        #region (Q2) (Write a program in C# Sharp to create a function to calculate the sum of the individual digits of a given number.)
        //Console.WriteLine("Enter a number");
        //int num;
        //while (!int.TryParse(Console.ReadLine(), out num)) { Console.WriteLine("Enter a valid number"); }
        //SumOfDigits(num);
        #endregion
        #region (Q3) ( Create a function named "IsPrime", which receives an integer number and retuns true if it is prime, or false if it is not .)
        //int num;
        //Console.WriteLine("Enter a number");
        //while (!int.TryParse(Console.ReadLine(), out num)) { Console.WriteLine("Enter a valid number"); }
        //Isprime(num);
        #endregion
        #region(Q4) (Create an iterative(non - recursive) function to calculate the factorial of the number specified as parameter)
        //Console.WriteLine("Enter the factorial number");
        //int num;
        //while (!int.TryParse(Console.ReadLine(), out num)) { Console.WriteLine("Enter a valid number"); }
        //factorial(num);
        #endregion
        #region (Q5) (Create a function named "ChangeChar" to modify a letter in a certain position (0 based) of a string, replacing it with a different letter)
        //char[] x = { 'a', 'b', 'c', 'd', 'e', 'f' };
        //changechar(x);
        #endregion


    }
}

