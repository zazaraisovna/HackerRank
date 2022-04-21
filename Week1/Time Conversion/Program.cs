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
     * Given a time in 12-hour AM/PM format, convert it to military (24-hour) time.
     * Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
     * 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock. 
     * 
     * Example
     * s = '12:01:00PM'
     * Return '12:01:00'.
     * s = '12:01:00AM'
     * Return '00:01:00'.
     */
    public static string timeConversion(string s)
    {
        return DateTime.Parse(s, CultureInfo.CreateSpecificCulture("fr-FR")).ToString("HH:mm:ss");
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
