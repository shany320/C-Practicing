public class program

{
    #region (1) (Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.)
    //public static int multbytwo(int x)
    //{
    //    x = x * 2;
    //    Console.WriteLine($"X during passing by value {x}");
    //    return x;
    //}
    //public static int multbytwo(ref int x)
    //{
    //    x = x * 2;
    //    Console.WriteLine($"X during passing by value {x}");
    //    return x;
    //}
    #endregion
    #region (2) (Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers)
    //public static int sumsub(int x, int y, int z, int w)
    //{
    //    int sum = x + y;
    //    int sub = z - w;
    //    Console.WriteLine($"Summation of {x} and {y} is {sum}");
    //    Console.WriteLine($"Subtraction of {z} and {w} is {sub}");
    //    return sum;
    //}
    #endregion
    #region (3)(Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters)
    //public static void MinMaxArray(int[] arr) 
    //{
    //    Array.Sort(arr);
    //    Console.WriteLine($"The minimum value in the array is {arr[0]}");
    //    Console.WriteLine($"The maximum value in the array is {arr[arr.Length - 1]}");
    //}
    #endregion
    static void Main()
    {
        #region (1) (Explain the difference between passing (Reference type parameters) by value and by reference then write a suitable c# example.)
        ////Passing by vale type: the value type parameters is not changed by changin its value.
        //int x = 5;
        //Console.WriteLine($"X before passing by value {x}");
        //multbytwo(x);
        //Console.WriteLine($"X after passing by value {x}");

        ////Passing by reference type: the reference type parameters is changed by changin its value.
        // int y=6;
        //Console.WriteLine($"Y before passing by reference {y}");
        //multbytwo( ref y);
        //Console.WriteLine($"Y after passing by reference {y}");


        #endregion
        #region (2) (Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers)
        //sumsub(5, 6, 8, 7);
        #endregion
        #region (3)(Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters)
        //Console.WriteLine("Enter the size of array");
        //int size;
        // while(!int.TryParse(Console.ReadLine(),out size)) { Console.WriteLine("Enter a valid number"); }
        //int[] arr = new int[size];
        //for (int i = 0; i < size; i++)
        //{
        //    Console.WriteLine($"Enter the value of element {i+1}");
        //    while (!int.TryParse(Console.ReadLine(), out arr[i])) { Console.WriteLine("Enter a valid number"); }
        //}
        //MinMaxArray(arr);
        #endregion

    }
}
