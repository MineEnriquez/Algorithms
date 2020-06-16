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


namespace MatchingSocksPairs
{
    class Program
    {
        // Complete the sockMerchant function below.
        static int sockMerchant(int n, int[] ar)
        {
            int pairs = 0;
            Dictionary<int, int> tracker = new Dictionary<int, int>();
            foreach (int x in ar)
            {
                if (tracker.Keys.Contains(x))
                {
                    tracker[x] = tracker[x] + 1;
                }
                else
                {
                    tracker.Add(x, 1);
                }
            }
            foreach (var entry in  tracker)
            {
                    pairs = pairs + (int)(entry.Value/2) ;

            }
            return pairs;
        }

        static void Main(string[] args)
        {
            int[] mysocks = new int[] {10, 20, 20, 10, 10, 30, 50, 10, 20};

            int pairs = sockMerchant(9, mysocks);

            Console.WriteLine(pairs);

            // TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            // int n = Convert.ToInt32(Console.ReadLine());

            // int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            // int result = sockMerchant(n, ar);

            // textWriter.WriteLine(result);

            // textWriter.Flush();
            // textWriter.Close();
        }

    }
}
