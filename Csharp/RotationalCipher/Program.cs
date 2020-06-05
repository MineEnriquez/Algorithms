using System;
using System.Diagnostics;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to
public class RotationalCipher
{
    static void Main(String[] args)
    {
        // Call rotationalCipher with test cases here
        Console.WriteLine("Rotational Cipher");
       test("Cheud-726?", rotationalCipher("Zebra-493?", 3));
       test("nopqrstuvwxyzABCDEFGHIJKLM9012345678", rotationalCipher("abcdefghijklmNOPQRSTUVWXYZ0123456789", 39));
    }
    private static string rotationalCipher(String input, int rotationFactor)
    {
        char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        string[] newarray = new string[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            string letter = input[i].ToString();
            if (Char.IsLetter(input[i]))
            {
                letter = letter.ToLower();
                int letter_index = Array.IndexOf(alpha, Convert.ToChar(letter));
                var offset = rotationFactor % 26;

                if (letter_index + offset >= 26)
                    offset = (letter_index + offset) - 26;
                else
                    offset = letter_index + offset;
                newarray[i] = alpha[offset].ToString();

                if (Char.IsUpper(input[i]))
                    newarray[i] = newarray[i].ToUpper();

            }
            else if (Char.IsNumber(input[i]))
            {
                var offset = rotationFactor % 10;
                int index = Convert.ToInt16(letter);
                if (index + offset >= 10) offset = index + offset - 10;
                else offset = index + offset;

                newarray[i] = (offset).ToString();
            }
            else newarray[i] = input[i].ToString();
        }
        return string.Join("", newarray);
    }
    private static void test(String expected, String actual)
    {
        Console.WriteLine($"TEST: \nEXPECTED: {expected} \nACTUAL:   {actual}  " );
        Debug.Assert(actual == expected, 
        "Test Failed",
        $"TEST expected: {expected}, actual {actual}  " );

        return;
    }
}