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

    // Complete the makeAnagram function below.
    static int makeAnagram(string a, string b)
    {
        //lets convert the two strings into an array of char.
        var aCharArr = a.ToCharArray();
        var bCharArr = b.ToCharArray();

        //lets store all the distinct char of first string
        var distinct1 = aCharArr.Distinct();
        var distinct2 = bCharArr.Distinct();

        var diffCount1 = 0;
        var diffCount2 = 0;
        foreach (char chr in distinct1)
        {
            var aCount = aCharArr.Where(c => c == chr).Count();
            var bCount = bCharArr.Where(c => c == chr).Count();

            if (aCount > bCount)
                diffCount1 += aCount - bCount;
        }
        foreach (char chr in distinct2)
        {
            var aCount = aCharArr.Where(c => c == chr).Count();
            var bCount = bCharArr.Where(c => c == chr).Count();

            if (bCount > aCount)
                diffCount2 += bCount - aCount;
        }

        return diffCount1 + diffCount2;

    }

    static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string a = Console.ReadLine();

        string b = Console.ReadLine();

        int res = makeAnagram(a, b);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
