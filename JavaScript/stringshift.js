function rotate(_str, direction, n){
    var _strarray = _str.split("");
    var temp = [];
    temp[0]="";
    var _temparray=[];
    for (i=0; i< n; i++){
        //removing the last element:
        if(direction=="right"){
            temp[0]=_strarray.pop();
            var _temparray = temp.concat(_strarray);
            _strarray = _temparray;
            temp[0]="";
        }
        else if (direction=="left"){
            temp=_strarray[0];
            for(j = 0; j< _strarray.length-1; j++){
                _strarray[j] = _strarray[j+1];
            }
            _strarray[_strarray.length-1] = temp;
        }
    }
    return _strarray.join("");

}
console.log(rotate("Hello world", "right", 2));