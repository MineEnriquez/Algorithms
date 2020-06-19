using System.IO;
using System;

class Solution {

    // Complete the countingValleys function below.
    static int countingValleys(int n, string s) {
        int valleys = 0;
        int verticalPoint = 0;
        
        foreach( char l in s){
            int currentPoint = verticalPoint;
            if (l=='D') verticalPoint --;
            else if (l=='U') verticalPoint++;
            if (currentPoint < verticalPoint && verticalPoint == 0) valleys++;
        }
        return valleys;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);
        int n = Convert.ToInt32(Console.ReadLine());
        string s = Console.ReadLine();
        int result = countingValleys(n, s);
        textWriter.WriteLine(result);
        textWriter.Flush();
        textWriter.Close();
    }
}
