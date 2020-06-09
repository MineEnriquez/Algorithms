using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to
public class EncryptedWords
{
    static void Main(String[] args)
    {
        // Call findEncryptedWord with test cases here
        Console.WriteLine(findEncryptedWord("abcxcba"));
        Console.WriteLine("xbacbca");
    }

    private static String findEncryptedWord(String s)
    {
        int len = s.Length;
        int half = 0;
        string mid = "";

        half = len / 2;
        if (len <= 1) return s;
        else mid = s.Substring(half, 1);
        string a = findEncryptedWord(s.Substring(0, half));
        string b = findEncryptedWord(s.Substring(half + 1, half));
        return mid + a + b;
    }
}