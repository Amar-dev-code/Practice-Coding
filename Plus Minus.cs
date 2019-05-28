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

class Solution
{

    static void Main(string[] args)
    {
        int arrp = 0;
        int arrn = 0;
        int arr0 = 0;

        int n = Convert.ToInt16(Console.ReadLine());

        string readline = Console.ReadLine();
        string[] arr = readline.Split(' ');
        for (int i = 0; i < n; i++)
        {
            if (int.Parse(arr[i]) > 0)
                arrp++;
            else if (int.Parse(arr[i]) < 0)
                arrn++;
            else
                arr0++;
        }
        string positive = Math.Round(((double)arrp / n), 6).ToString();
        string[] decimalcheck = positive.Split('.');
        if ((arrn == 0 && arr0 == 0) || (arrp == 0))
        {
            Console.WriteLine((positive + ".").PadRight(8, '0'));
            //if (decimalcheck[0].Length != 6)
            //{
            //    int number = (6 - decimalcheck[0].Length);
            //    Console.WriteLine(positive.PadRight(decimalcheck[0].Length + number + 1, '0'));
            //}
        }
        else
        {
            if (decimalcheck[1].Length != 6)
            {
                int number = (6 - decimalcheck[1].Length);
                Console.WriteLine(positive.PadRight(decimalcheck[0].Length + decimalcheck[1].Length + number + 1, '0'));
            }
            else
            {
                Console.WriteLine(positive);
            }
        }
        //else
        //Console.WriteLine(positive);
        //negative
        string negative = Math.Round(((double)arrn / n), 6).ToString();
        string[] decimaln = negative.Split('.');
        if ((arrp == 0 && arr0 == 0) || (arrn == 0))
        {
            Console.WriteLine((negative + ".").PadRight(8, '0'));
            //if (decimaln[0].Length != 6)
            //{
            //    int number = (6 - decimaln[0].Length);
            //    Console.WriteLine(negative.PadRight(decimaln[0].Length + number + 1, '0'));
            //}
        }
        else
        {
            if (decimaln[1].Length != 6)
            {
                int number = (6 - decimaln[1].Length);
                Console.WriteLine(negative.PadRight(decimaln[0].Length + decimaln[1].Length + number + 1, '0'));
            }
            else
            {
                Console.WriteLine(negative);
            }
        }
        //else
        //    Console.WriteLine(negative);
        //zero
        string zero = Math.Round(((double)arr0 / n), 6).ToString();
        string[] decimal0 = zero.Split('.');
        if ((arrn == 0 && arrp == 0) || arr0 == 0)
        {
            Console.WriteLine((zero + ".").PadRight(8, '0'));
            //if (decimal0[0].Length != 6)
            //{
            //    int number = (6 - decimal0[0].Length);
            //    Console.WriteLine(zero.PadRight(decimal0[0].Length + number + 1, '0'));
            //}
        }
        else
        {
            if (decimal0[1].Length != 6)
            {
                int number = (6 - decimal0[1].Length);
                Console.WriteLine(zero.PadRight(decimal0[0].Length + decimal0[1].Length + number + 1, '0'));
            }
            else
            {
                Console.WriteLine(zero);
            }
        }
        //else
        //    Console.WriteLine(zero);



    }
}
