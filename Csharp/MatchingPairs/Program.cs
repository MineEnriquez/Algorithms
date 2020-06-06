using System;

// We don’t provide test cases in this language yet, but have outlined the signature for you. Please write your code below, and don’t forget to test edge cases!
class MatchingPairs {
  static void Main(string[] args) {

    Console.WriteLine( matchingPairs("test", "ttes")); 
  }
  
  private static int matchingPairs(string s, string t) {
    int counter = 0;
    int oneSideMatch = 0;
    int crossMatch = 0;
    for( int i = 0; i<s.Length; i++)
    {
        if (s[i] == t[i]){
            counter ++;
            continue;
        }
        else if (s[i] != t[i]){      
            for(int j = i; j<t.Length; j++){
                if (s[i] == t[j] && s[j]==t[i]){  
                     crossMatch = j;
                     break; // we have found a both sided matching pair, so swapping them up will ensure that we have 2 matching pairs.
                }
                else if (s[i] == t[j] && s[j]!=t[i]){  
                    oneSideMatch = j;
                }
            }
            //swap 
            if ( crossMatch!= 0 ) 
            { 
              s[i] = s[crossMatch];
              counter++;
            }
        }
    }
  
    
    return counter;
  }
}