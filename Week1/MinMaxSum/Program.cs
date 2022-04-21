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
     * Given five positive integers, find the minimum and maximum values that can be calculated 
     * by summing exactly four of the five integers. Then print the respective minimum and maximum 
     * values as a single line of two space-separated long integers.
     * 
     * Example
     * arr[1,3,5,7,9]
     * The minimum sum is 1 + 3 + 5 + 7 = 16 and the maximum sum is 3 + 5 + 7 + 9 = 24.
     * The function prints 16 24
     */
    public static void miniMaxSum(List<int> arr)
    {
        long sum = 0;
        long min_sum = 0;
        long max_sum = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            sum = 0;
            for (int j = 0; j < arr.Count; j++)
            {
                if (i != j)
                {
                    sum += arr[j];
                }
            }
            if (sum > max_sum) max_sum = sum;
            if (sum < min_sum || min_sum == 0) min_sum = sum;
        }
        Console.Write(min_sum + " " + max_sum);
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
