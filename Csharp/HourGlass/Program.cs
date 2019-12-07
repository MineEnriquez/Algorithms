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

namespace HourGlass
{

class Solution {

    // Complete the hourglassSum function below.
    static int hourglassSum(int[][] arr) {
       int maxHg =0;
       int hg =0;
        for (int r = 0; r < 4; r++ ){
            for (int c = 0; c<4; c++){
                hg = 0;
                hg = arr[r][c] + arr[r][c+1] + arr[r][c+2];
                hg += arr[r+1][c+1];
                hg += arr[r+2][c] + arr[r+2][c+1] + arr[r+2][c+2];
                
                if (hg > maxHg){
                    maxHg = hg;
                }
            }
        }
        return maxHg;
    }

    static void Main(string[] args) {
        //TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int[][] arr = new int[6][];

        for (int i = 0; i < 6; i++) {
            arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
        }

        int result = hourglassSum(arr);

        /*textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();*/
    }
}
}
