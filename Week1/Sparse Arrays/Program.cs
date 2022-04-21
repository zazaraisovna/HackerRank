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
     * There is a collection of input strings and a collection of query strings. For each query string,
     * determine how many times it occurs in the list of input strings. Return an array of the results.
     * 
     * Function Description
     * Complete the function matchingStrings in the editor below. The function must return an array of 
     * integers representing the frequency of occurrence of each query string in strings.
     * matchingStrings has the following parameters:
     * string strings[n] - an array of strings to search
     * string queries[q] - an array of query strings
     */

    public static List<int> matchingStrings(List<string> strings, List<string> queries)
    {
        List<int> list = new List<int>();
        for (int i = 0; i <= queries.Count - 1; i++)
        {
            int cnt = 0;
            for (int j = 0; j <= strings.Count - 1; j++)
            {
                if (queries[i] == strings[j])
                    cnt++;
            }
            list.Add(cnt);
        }
        return list;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int stringsCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> strings = new List<string>();

        for (int i = 0; i < stringsCount; i++)
        {
            string stringsItem = Console.ReadLine();
            strings.Add(stringsItem);
        }

        int queriesCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<string> queries = new List<string>();

        for (int i = 0; i < queriesCount; i++)
        {
            string queriesItem = Console.ReadLine();
            queries.Add(queriesItem);
        }

        List<int> res = Result.matchingStrings(strings, queries);

        textWriter.WriteLine(String.Join("\n", res));

        textWriter.Flush();
        textWriter.Close();
    }
}