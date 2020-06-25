var longestPalindrome = function(_str){
    var letters = {};
    // Create hash map
    for(var i=0; i<_str.length; ++i){
        var si = _str[i];
        if (letters[si]){
            letters[si]++
        }
        else {
            letters[si] = 1;
        }
    }

    //scans the hashmaps for pairs
    var totalPairs = 0;
    // the string onlycan contain 1 odd number, so we better make sure is the one
    // with maximum number of letters:
    var maxOdd = 0; 

    for (var l in letters) {
        var totalLetters = letters[l];
        if ((totalLetters/2 - Math.floor(totalLetters/2)) > 0)  //is Odd
        {         
            if(totalLetters > maxOdd){
                maxOdd = totalLetters;
            }
        }
        else{
            totalPairs+= totalLetters;
        }
     }
     return totalPairs + maxOdd;
};


console.log(longestPalindrome("MMMMooooasdfsuyukcasderwermSSWfffASAIPOOIPNMNRTRTeqweqweqweqwezxczxqweqweooiuiuiuiuiumoomoom"));