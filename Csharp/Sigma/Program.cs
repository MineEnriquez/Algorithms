using System;

namespace Sigma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // int sigma = Sigma(13);
            // Console.WriteLine(sigma);
            int[] calculate = new int[] {12, 34, 34, 34, 56, 23423, 23, 23};
            int ave = Average(calculate);
        }
        public static int Sigma(int num){
            int result =0;
            for(int i=1; i< num+1; i++){
                result = result + i;
            }
            return result;
        }     

        public static int Average(Array population){
            int result = 0;
            int totalSample = population.Length;
            double total = 0;
                foreach (int x in population){
                        total = total + x;
                }

            
                result =Convert.ToInt16( total / Convert.ToDouble(totalSample));
            return result;
        }   
    }
}
