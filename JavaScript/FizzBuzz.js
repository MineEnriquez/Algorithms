function fizzbuzz(_param) {
    var _result = "";
    for (var i = 1; i < _param + 1; i++) {
        var str1 = "";
        var str2 = "";
        if (i % 3 == 0) {
            str1 = "Fizz";
        }
        if (i % 5 == 0) {
            str2 = "Buzz";
        }
        if (i % 5 != 0 && i % 3 != 0) {
            str1 = i;
            str2 = "";
        }
        if( i == 1 ){
            _result = str1 + str2;
        }
        else{
            i < _param ? _result = _result + ", " + str1 + str2 : _result = _result + ", and " + str1 + str2
        }
    }
    console.log(_result);
    }

fizzbuzz(15);