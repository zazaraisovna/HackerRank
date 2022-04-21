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
     * Given an array of integers, where all elements but one occur twice, find the unique element.
     * Example
     * a = [1, 2, 3, 4, 3, 2, 1]
     * The unique element is 4.
     */

    public static int lonelyinteger(List<int> a)
    {
        for (int i = 0; i < a.Count; i++)
        {
            int cnt = 1;
            for (int j = 0; j < a.Count; j++)
            {
                if ((a[i] == a[j]) && (i != j)) cnt++;
            }
            if (cnt == 1) return a[i];
        }
        return 0;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();

        int result = Result.lonelyinteger(a);

        Console.WriteLine(result);
    }
}
