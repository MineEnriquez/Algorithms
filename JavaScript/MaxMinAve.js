/* Given an array with multiple values, 
write a function that returns a new array that only contains the maximum,
 minimum, and average values of the original array.
  (e.g. [1,5,10,-2] will return [10,-2,3.5]) */
  
  function maxMinAvg(arr) {
    var arrnew = [0,0,0];
    for(var i =0; i< arr.length; i++){
        if(arr[i]> arrnew[0]) {
            arrnew[0] = arr[i];
        }
        if (arr[i]< arrnew[1]){
            arrnew[1] = arr[i];
        }
        arrnew[2] = arrnew[2] + arr[i];
    }
    arrnew[2] = arrnew[2]/arr.length;
    //your code here 
    return arrnew; 
}