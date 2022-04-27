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
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. STRING s
     *  2. INTEGER k
     */
    public static string caesarCipher(string s, int k)
    {
        const string abc = "abcdefghijklmnopqrstuvwxyz";
        const string up_abc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        int abc_cnt = abc.Count();
        int up_cnt = up_abc.Count();
        string[] chiper = new string[abc_cnt];
        string[] up_chiper = new string[abc_cnt];

        string[] temp = new string[s.Count()];

        if (k >= abc_cnt) k = k % abc_cnt;
        for (int j = 0; j < abc_cnt - k; j++)
        {
            chiper[j] = abc[j + k].ToString();
            up_chiper[j] = up_abc[j + k].ToString();
        }

        for (int l = 0; l < k; l++)
        {
            chiper[abc_cnt - k + l] = abc[l].ToString();
            up_chiper[abc_cnt - k + l] = up_abc[l].ToString();
        }

        for (int i = 0; i < s.Count(); i++)
        {
            if (abc.Contains(s[i].ToString()))
            {
                temp[i] = chiper[abc.IndexOf(s[i].ToString())];
            }
            else if (up_abc.Contains(s[i].ToString()))
            {
                temp[i] = up_chiper[up_abc.IndexOf(s[i].ToString())];
            }
            else temp[i] = s[i].ToString();
        }

        return string.Join("", temp);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        string s = Console.ReadLine();

        int k = Convert.ToInt32(Console.ReadLine().Trim());

        string result = Result.caesarCipher(s, k);

        Console.WriteLine(result);
    }
}
