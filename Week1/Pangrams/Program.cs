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

    // Problem.txt

    public static string pangrams(string s)
    {
        int count = s.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count();
        if (count == 26)
            return "pangram";
        else
            return "not pangram";

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        string s = Console.ReadLine();

        string result = Result.pangrams(s);

        Console.WriteLine(result);
    }
}
