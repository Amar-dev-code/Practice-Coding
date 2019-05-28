﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the gradingStudents function below.
     */
    static int[] gradingStudents(int[] grades)
    {
        int i;
        int n = grades.Length;
        int[] value = new int[n];
        for (i = 0; i < n; i++)
        {
            int count = 0;
            int temp = grades[i];
            while (grades[i] % 5 != 0 && count < 2 && grades[i] >= 38)
            {
                grades[i] = grades[i] + 1;
                count++;
            }
            if (grades[i] % 5 != 0)
                value[i] = temp;
            else
                value[i] = grades[i];
        }
        return value;
    }

    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] grades = new int[n];

        for (int gradesItr = 0; gradesItr < n; gradesItr++)
        {
            int gradesItem = Convert.ToInt32(Console.ReadLine());
            grades[gradesItr] = gradesItem;
        }

        int[] result = gradingStudents(grades);

        tw.WriteLine(string.Join("\n", result));

        tw.Flush();
        tw.Close();
    }
}
