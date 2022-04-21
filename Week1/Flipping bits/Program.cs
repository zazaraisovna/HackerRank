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
     * Вам предоставляется список 32-битных беззнаковых целых чисел. Вы должны вывести список беззнаковых 
     * целых чисел, полученных инвертированием битов в их двоичном представлении (то есть, неустановленные
     * биты должны быть установленными, а установленные - неустановленными).
     * Input Format
     * Число в первой строке обозначает размер списка чисел. Начиная со второй строки будут записаны числа,
     * по одному в строке. В списке будет не более 100 элементов.
     * Output Format
     * Выведите по одному элементу полученного списка в строке.
     * 
     * Sample Input
     * 3 
     * 2147483647 
     * 1 
     * 0
     * 
     * Sample Output
     * 2147483648 
     * 4294967294 
     * 4294967295
     */

    public static long flippingBits(long n)
    {
        string twobit = Convert.ToString(n, 2).PadLeft(32, '0');

        int[] a = new int[twobit.Length];
        for (int i = 0; i < twobit.Length; i++)
        {
            if (twobit[i] == '0') a[i] = 1;
            else a[i] = 0;
        }

        string res = string.Join("", a);
        return Convert.ToInt64(res, 2);
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int q = Convert.ToInt32(Console.ReadLine().Trim());

        for (int qItr = 0; qItr < q; qItr++)
        {
            long n = Convert.ToInt64(Console.ReadLine().Trim());

            long result = Result.flippingBits(n);

            Console.WriteLine(result);
        }
    }
}
