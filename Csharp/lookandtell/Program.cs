using System;

// namespace lookandtell
// {
    class Program
    {
        static void Main(string[] args)
        {
        int n = 10;
        Console.Write(LookAndTell(n));
        }
 static string LookAndTell(int n){
        
        if (n == 1) return "1";
        if (n == 2) return "11";
        string _seeAndTell = "11";

        for(int i=3; i<=n; i++){
            char[] chararray = _seeAndTell.ToCharArray();
            _seeAndTell = "";
            int counter = 0;
            char lookingat = ' ';
            for(int j = 0; j<chararray.Length; j++){
                if(j==0){ //first iteraction
                    counter = 1;
                    lookingat = chararray[0];
                }
                else{
                    if(chararray[j]==lookingat){
                        counter++;
                    }
                    else
                    {
                        _seeAndTell = _seeAndTell + counter.ToString() + lookingat.ToString();
                        counter = 1;
                        lookingat = chararray[j];
                    }
                }
            }
            _seeAndTell = _seeAndTell + counter.ToString() + lookingat.ToString();
            Console.WriteLine("current:" + _seeAndTell);
        }

        Console.WriteLine("Finished-------------");
        return _seeAndTell;
    }

    }
// }
