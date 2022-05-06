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
     * The function is expected to return an INTEGER_ARRAY.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. 2D_INTEGER_ARRAY queries
     */

    public static List<int> dynamicArray(int n, List<List<int>> queries)
    {
        List<List<int>> arr = new List<List<int>>();
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < n; j++)
                arr[i][j] = 0;
        }
        int lastAnswer = 0;
        List<int> ans = new List<int>();
        for (int i = 0; i < n; ++i)
            ans.Add(0);
        foreach (List<int> query in queries)
        {
            int x = query[1];
            int y = query[2];
            if (query[0] == 1)
            {
                int idx = ((x ^ lastAnswer) % n);
                arr[idx].Append(y);
            }
            else
            {
                int idx = ((x ^ lastAnswer) % n);
                lastAnswer = arr[idx][y % (arr[idx]).Count()];
                ans.Add(lastAnswer);
            }
        }
        return ans;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

        int n = Convert.ToInt32(firstMultipleInput[0]);

        int q = Convert.ToInt32(firstMultipleInput[1]);

        List<List<int>> queries = new List<List<int>>();

        for (int i = 0; i < q; i++)
        {
            queries.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(queriesTemp => Convert.ToInt32(queriesTemp)).ToList());
        }

        List<int> result = Result.dynamicArray(n, queries);

        Console.WriteLine(String.Join("\n", result));
    }
}