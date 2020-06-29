function ValidBraces(_param1 ){
    var openers = ["{", "(", "["];
    var closers = ["}", ")", "]"]
    var validationStack = [];
    var stringarray = _param1.split("");

    for (var i = 0; i < stringarray.length ; i++) {
        var element = stringarray[i];
            if(openers.includes(element)){
                validationStack.push(element);
              }
            else if (closers.includes(element)){
                var top = validationStack.slice(-1)[0];
                if(top == "(" && element==")"){
                    validationStack.pop();
                }
                else if(top == "{" && element=="}"){
                    validationStack.pop();
                }
                else if(top == "[" && element=="]"){
                    validationStack.pop();
                }
                else {
                    return false;
                }
            }
        }
        return true;
}

console.log(ValidBraces(")(hola){cs}"));
