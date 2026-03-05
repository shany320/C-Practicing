using C_Adv_Ass_1;
using System;

class Program
{

    static void Main()
    {
        #region Q1(The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimize the Bubble Sort algorithm And implement the code of this optimized bubble sort algorithm)

        //int[] numbers = { 4, 5, 6, 2, 1, 8 };
        //Helper.BubbleSort(numbers);
        #endregion
        #region Q2(create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.)
        Range<int> intRange = new Range<int>(20, 10);
        Console.WriteLine(intRange.Isinrange(15)); // The Value you entered is in within range!
        Console.WriteLine(intRange.length()); // 10

        Range<double> doubleRange = new Range<double>(10.2, 5.5);
        Console.WriteLine(doubleRange.Isinrange(7.5)); // The Value you entered is in within range!
        Console.WriteLine(doubleRange.length()); //4.6999
        #endregion

    }
}
