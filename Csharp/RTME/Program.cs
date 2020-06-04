using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
class ReverseToMakeEqual
{
    static void Main(string[] args)
    {
        // Call areTheyEqual() with test cases here
        int[] A = { 1, 2, 3, 4, 5, 6, 7, 8 };
        int[] B = { 1, 4, 3, 2, 5, 11, 7, 6 };
        Console.WriteLine(areTheyEqual(A, B));
    }

    private static bool areTheyEqual(int[] arr_a, int[] arr_b)
    {
        int i = 0;
        int j = 0;
        int offset = 0;

        while (i < arr_a.Length)
        {
            // Console.Write(arr_a[i]);
            // Console.Write("<-->");
            // Console.WriteLine(arr_b[j]);
            if (arr_a[i] == arr_b[j])
            {
                // Console.WriteLine(i);
                i++;
                j++;
            }
            else
            {
                while (j < arr_b.Length)
                {
                    if (arr_a[i] != arr_b[j])
                    {
                        j++;
                        offset++;
                        if (j == arr_b.Length) return false;
                    }
                    else
                    {
                        break;
                    }
                }

                for (int k = 0; k < offset + 1; k++)
                {
                    if (i < arr_a.Length)
                    {
                        // Console.Write(arr_a[i++]);
                        // Console.Write("--");
                        // Console.WriteLine(arr_b[j - k]);
                        if (arr_a[i++] != arr_b[j - k])
                        {
                            return false;
                        }

                    }
                }
                j = i;
            }
        }
        return true;
    }
}