using System;
using System.Text.RegularExpressions;

class Solution
{
    static void Main(string[] args)
    {
            Console.WriteLine(isPalindrome(""));
    }
    
    static bool isPalindrome(string str){
        if (str.Length<1) return false;
        var c = Regex.Replace(str, @"\s+", String.Empty).ToCharArray();      
        for( int i=0; i< c.Length/2; i++) if (c[i] != c[c.Length - 1 - i]) return false;
        return true;
    }
}
