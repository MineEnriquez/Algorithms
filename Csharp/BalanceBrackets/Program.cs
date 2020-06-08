using System;
using System.Collections;

class BalancedBrackers
{
    static void Main(string[] args)
    {
        string s = "";
        // 1
        //output: true
        s = "{[()]}";
        Console.WriteLine(isBalanced(s));

        //Example 2
        //output: true
        s = "{}()";
        Console.WriteLine(isBalanced(s));

        // Example 3
        // Output: false
        s = "{(})";
        Console.WriteLine(isBalanced(s));

        // Example 4
        // Output: false
        s = ")";
        Console.WriteLine(isBalanced(s));
        
        // Example 5
        // Output: false
        s = "a(";
        Console.WriteLine(isBalanced(s));
    }

    private static bool isBalanced(string s)
    {
        string opening = "{[(";
        string closing = ")}]";
        Stack st = new Stack();

        if (s.Length < 2) return false;

        foreach (var x in s)
        {
            if ((opening + closing).IndexOf((char)x) >= 0)
            {
                //Is an opening character
                if (opening.IndexOf((char)x) >= 0)
                {
                    st.Push(x);
                }
                // Is a closing character
                else if (closing.IndexOf((char)x) >= 0 && st.Count > 0)
                {
                    string top = st.Peek().ToString();
                    if (x.ToString() == ")" && top == "(") st.Pop();
                    else if (x.ToString() == "}" && top == "{") st.Pop();
                    else if (x.ToString() == "]" && top == "[") st.Pop();
                    else return false;
                    Console.WriteLine(top + x.ToString());
                }
                else if (closing.IndexOf((char)x) >= 0 && st.Count == 0) return false;
            }
        }
        // No elements should have been left in the stack.
        if(st.Count > 0)  return false;

        return true;
    }
}