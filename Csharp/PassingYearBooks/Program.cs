using System;
class PassingYearbooks {
  static void Main(string[] args) {
    int[] test1 ={4,3,2,5,1};
    int[] test2 ={2,1};
    int[] test3 ={1,2};
  
    Console.WriteLine("[{0}] -->  [{1}]", String.Join(',', test1), String.Join(',', findSignatureCounts(test1)));
    Console.WriteLine("[{0}] -->  [{1}]", String.Join(',', test2), String.Join(',', findSignatureCounts(test2)));
    Console.WriteLine("[{0}] -->  [{1}]", String.Join(',', test3), String.Join(',', findSignatureCounts(test3)));
  }
  
  private static int[] findSignatureCounts(int[] arr) {
    int[] newarr = new int[arr.Length];
    Array.Fill(newarr, 1);
    for(int i = 0; i< arr.Length ; i++){
      var j = i;
      while (arr[j] != i+1){
        newarr[i]++;
        j = arr[j] - 1;
      }
    }
    return newarr;
  }
}