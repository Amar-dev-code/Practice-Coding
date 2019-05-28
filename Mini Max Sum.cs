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

    // Complete the miniMaxSum function below.


    static void Main(string[] args)
    {

        Int64 Minsum = 0;
        Int64 MaxSum = 0;
        string readline = Console.ReadLine();
        string[] arr = readline.Split(' ');
        for (int i = 0; i < 5; i++)
        {
            for (int j = i + 1; j < 5; j++)
            {
                if (Int64.Parse(arr[i]) > Int64.Parse(arr[j]))
                {
                    string temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                }
            }
        }
        for (int k = 0; k < 4; k++)
        {
            Minsum = Minsum + Int64.Parse(arr[k]);
            MaxSum = MaxSum + Int64.Parse(arr[4 - k]);
        }
        Console.Write(Minsum + " " + MaxSum);

    }
}
