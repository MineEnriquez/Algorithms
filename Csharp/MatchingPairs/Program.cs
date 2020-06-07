using System;
class MatchingPairs
{
    static void Main(string[] args)
    {
        Console.WriteLine(matchingPairs("mno", "mno"));
        Console.WriteLine(matchingPairs("abcd", "adcb"));
        Console.WriteLine(matchingPairs("mn", "mn"));
    }

    private static int matchingPairs(string s, string t)
    {
        int counter = 0;
        bool oneSideMatch = false;
        bool crossMatch = false;
        bool swapped = false;

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == t[i])
            {
                counter++;
                continue;
            }
            else if (s[i] != t[i] && !swapped)
            {
                for (int j = i; j < t.Length; j++)
                {
                    if (s[i] == t[j] && s[j] == t[i])
                    {
                        crossMatch = true;
                        swapped = true;
                        break;
                    }
                    if (s[i] == t[j] && s[j] != t[i])
                    {
                        swapped = true;
                        oneSideMatch = true;
                    }
                }
            }
        }
        if (crossMatch || oneSideMatch)  // If we ever spotted the values to be swapped:
        {
            if (crossMatch)
                counter = counter + 2;
            else if (oneSideMatch)
                counter++;
        }
        else  if ( ! swapped && counter >= 2)  // If we never found a value to be swapped, it means that all of them were the same, 
                // therefore swapping 2 of them will reduce the counter by 2.
            counter = counter - 2;

        return counter;
    }
}