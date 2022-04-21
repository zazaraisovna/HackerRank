using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    /*
     * Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. 
     * Print the decimal value of each fraction on a new line with 6 places after the decimal.
     * 
     * Note: This challenge introduces precision problems. The test cases are scaled to six decimal places, 
     * though answers with absolute error of up to 10^(-4) are acceptable.
     * 
     * Sample Input
     * 6
     * -4 3 -9 0 4 1
     * 
     * Sample Output
     * 0.500000
     * 0.333333
     * 0.166667
     */

    public static void plusMinus(List<int> arr)
    {
        int pos = 0;
        int neg = 0;
        int zer = 0;
        int n = arr.Count;
        foreach (int i in arr)
        {
            if (i > 0) pos++;
            else if (i < 0) neg++;
            else if (i == 0) zer++;
        }

        double x = (pos / n);
        Console.WriteLine("{0:0.000000}", (float)pos / (float)n);
        Console.WriteLine("{0:0.000000}", (float)neg / (float)n);
        Console.WriteLine("{0:0.000000}", (float)zer / (float)n);
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}
