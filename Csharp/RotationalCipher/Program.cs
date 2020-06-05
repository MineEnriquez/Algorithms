using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Text.Encodings;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to
public class RotationalCipher
{
    static void Main(String[] args)
    {
        // Call rotationalCipher with test cases here
        Console.WriteLine("Rotational Cipher");
        Console.WriteLine(rotationalCipher("Zebra-493?", 3));
        Console.WriteLine(rotationalCipher("abcdefghijklmNOPQRSTUVWXYZ0123456789", 39));

    }

    private static string rotationalCipher(String input, int rotationFactor)
    {
        char[] inputarr = input.ToCharArray();
        char[] alpha = "abcdefghijklmnopqrstuvwxyz".ToCharArray();
        string[] newarray = new string[inputarr.Length];

        for (int i = 0; i < inputarr.Length; i++)
        {
            string letter = inputarr[i].ToString();
            if (Char.IsLetter(inputarr[i]))
            {
                letter = letter.ToLower();
                int letter_index = Array.IndexOf(alpha, Convert.ToChar(letter));
               var offset = rotationFactor % 26;

                if (letter_index + offset > 25)
                    offset = (letter_index + offset) - 25-1;
                else
                    offset = letter_index + offset;
                newarray[i] = alpha[offset].ToString();

                if (Char.IsUpper(inputarr[i]))                 
                    newarray[i] = newarray[i].ToUpper();
                
            }
            else if (Char.IsNumber(inputarr[i]))
            {
                var offset = rotationFactor % 10;
                int index = Convert.ToInt16(letter);
                if (index + offset > 10) offset = index + offset - 10;
                else offset = index + offset;
                newarray[i] = (offset).ToString();
            }
            else newarray[i] = inputarr[i].ToString();
        }

        return string.Join("", newarray);
    }
}