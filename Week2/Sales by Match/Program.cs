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
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. INTEGER n
     *  2. INTEGER_ARRAY ar
     */

    public static int sockMerchant(int n, List<int> ar)
    {
        List<int> pairs = new List<int>();
        for (int i = 0; i < n; i++)
        {
            if (!pairs.Contains(ar[i]))
            {
                int cnt = 0;
                for (int j = i; j < n; j++)
                {
                    if (ar[i] == ar[j])
                        cnt++;
                }
                if (cnt % 2 == 0)
                    for (int k = 0; k < cnt / 2; k++)
                        pairs.Add(ar[i]);
            }
        }
        return pairs.Count;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();

        int result = Result.sockMerchant(n, ar);

        Console.WriteLine(result);
    }
}
