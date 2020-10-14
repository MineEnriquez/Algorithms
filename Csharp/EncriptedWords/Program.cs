using System;
using System.Diagnostics;

public class EncryptedWords
{
    static void Main(String[] args)
    {
        Test("abc", "bac");
        Test("abcxcba", "xbacbca");
        Test("facebook", "eafcobok");
        Test("abcd", "bacd");
    }
    public static void Test(string test, string expected)
    {
        string actual = findEncryptedWord(test);
        Console.WriteLine($"TEST: {test} EXPECTED: {expected}");
        if (actual == expected) Console.WriteLine("\tPASS ");
        else Console.WriteLine($"\tFAILED - Expected:  {expected}, Actual: { actual}");
    }
    private static String findEncryptedWord(String s)
    {
        int len = s.Length;
        int half = len / 2;
        string mid = "";
        string a = "";
        string b = "";

        if (len % 2 > 0)
        {
            if (len <= 1) return s;
            else mid = s.Substring(half, 1);
            a = s.Substring(0, half);
            b = s.Substring(half + 1, len - half - 1);
        }
        else
        {
            if (len == 2) return s;
            else mid = s.Substring(half - 1, 1);
            a = s.Substring(0, half - 1);
            b = s.Substring(half, len - half);
        }

        return mid + findEncryptedWord(a) + findEncryptedWord(b);
    }
}
