using System;
using System.Runtime.Versioning;
using System.Security.Cryptography.X509Certificates;

namespace ReverseWordsInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            
           string[] myarray = new string[5]{"Hola", "Miss", "Stphanie", "Monique", "bonita"};
           foreach (string x in myarray){
               char[] word = x.ToCharArray();
               for (int i=0; i < word.Length; i++ ){

               }
           }
        }
    }
}
