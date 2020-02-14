using System;
using System.IO;

namespace CountingWords
{
    class Program
    {
        static void Main(string[] args)
        {
            // In this particular sample we will count the instances of the letter 'a'
            // on a string that repeats itself but can have a maximum length of 100 chars
            Console.WriteLine(countwords(100, "aniurfuyaauba"));
        }
        static int countwords(int n, string s){
	
            int total = 0;
            char[] schar = s.ToCharArray();
            int stringLen = s.Length;
            int minTimes = 0;
            for(int i = 0; i< stringLen; i++) {
                if(schar[i] == 'a'){
                    minTimes++;
                }
            }
            int x = (n / stringLen); // the number of times that given the length of the string is possible to have.
            int y = n - (x * stringLen); // n minus the lenght of the string already analyzed 
            total = minTimes * x; //total so far.

            for (int i = 0 ; i< y; i++){
                if(schar[i] == 'a'){
                    total++;
                }
            }

            Console.WriteLine( total);
            return total;
        }
    }
}
