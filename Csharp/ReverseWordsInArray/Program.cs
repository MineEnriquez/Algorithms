using System;					
public class Program
{
	public static void Main()
	{
		   string[] myarray = new string[5]{"Hola", "Miss", "Stphanie", "Monique", "bonita"};
           for(int j = 0; j<myarray.Length; j++){
               char[] word = myarray[j].ToCharArray();
                for (int i=0; i < word.Length/2; i++ ){
				   char temp = word[i];
				   word[i] = word[word.Length-1-i];
					word[word.Length-1-i] = temp;
               }
			   myarray[j] = new string(word);
			   Console.WriteLine(myarray[j]);	   
           }	
	}
}
