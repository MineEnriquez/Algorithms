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

namespace NewYearChaos
{

class Solution {

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q) {
        int moves = 0;
        for(int i = q.Length-1; i>=0 ; i-- )
        {
            //if ofset is way too big
            if (q[i] - (i + 1) > 2) {
                Console.WriteLine("Too chaotic");
                return;
            }
            
            for (int j = Math.Max(0, q[i] - 2); j < i; j++)
            if (q[j] > q[i]) moves++;
            
        }

        Console.WriteLine(moves);
        return;
    }

    static void Main(string[] args) {
        int[] q = {2, 1, 5, 3, 4};
        minimumBribes(q);
        
        int[] w = {2, 5, 1, 3, 4};
        minimumBribes(w);
        // int t = Convert.ToInt32(Console.ReadLine());

        // for (int tItr = 0; tItr < t; tItr++) {
        //     int n = Convert.ToInt32(Console.ReadLine());

        //     int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))            ;
        //     minimumBribes(q);
        // }
    }

    static void print(Object x){
        Console.WriteLine(x);
    }
}
}
