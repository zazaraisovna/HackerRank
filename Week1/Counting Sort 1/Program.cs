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
     * 
     */

    public static List<int> countingSort(List<int> arr)
    {
        int[] res = new int[arr.Count];
        for (int i = 0; i < arr.Count; i++)
        {
            res[arr[i]]++;
        }

        List<int> resList = res.ToList();
        if (resList[resList.Count - 2] == 0)
            for (int i = resList.Count - 1; i >= 0; i--)
            {
                if (resList[i] == 0)
                {
                    resList.RemoveAt(i);
                }
                else
                {
                    break;
                }
            }
        return resList;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        List<int> result = Result.countingSort(arr);

        Console.WriteLine(String.Join(" ", result));
    }
}