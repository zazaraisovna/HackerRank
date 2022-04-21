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
     * Given a square matrix, calculate the absolute difference between the sums of its diagonals.
     * For example, the square matrix arr is shown below:
     * 1 2 3
     * 4 5 6
     * 9 8 9
     * The left-to-right diagonal 1 + 5 + 9 = 15. The right to left diagonal 3 + 5 + 9 = 17.
     * Their absolute difference is |15 - 17| = 2.
     */

    public static int diagonalDifference(List<List<int>> arr)
    {
        int d1 = 0;
        int d2 = 0;
        for (int i = 0; i < arr.Count; i++)
        {
            for (int j = 0; j < arr.Count; j++)
            {
                if (i == j) d1 += arr[i][j];
                if ((i + j - 1) == arr.Count - 2) d2 += arr[i][j];
            }
        }
        return Math.Abs(d2 - d1);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        Console.WriteLine(result);
    }
}