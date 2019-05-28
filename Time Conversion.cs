using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution
{

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s)
    {
        string check = "AM";
        string check12AM = "12:00:00AM";
        string check12PM = "12:00:00PM";
        string value1 = "00:00:00";
        if (s.Substring(0) == check12AM.Substring(0))
            return (value1.Substring(0, 8));
        else if (s.Substring(0) == check12PM.Substring(0))
            return (s.Substring(0, 8));
        else if (s.Substring(8) == check.Substring(0))
        {
            if (s.Substring(0, 2) == "12")
                return "00" + s.Substring(2, 6);
            else
                return s.Substring(0, 8);
        }
        else
        {
            if (s.Substring(0, 2) == "12")
                return "12" + s.Substring(2, 6);
            else
            {
                int value = Convert.ToInt16(s.Substring(0, 2));
                int pm = value + 12;
                string cs = Convert.ToString(pm);
                return cs.Substring(0) + s.Substring(2, 6);
            }
        }

    }

    static void Main(string[] args)
    {
        //TextWriter tw = new StreamWriter(Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        Console.WriteLine(result);
        Console.ReadKey();
    }
}
