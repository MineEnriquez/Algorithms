function countingValleys(n, s) {
var v = 0;
var totalsteps = 0;
var hasvisitedavalley = false;
for( var i=0; i<n; i++){
    if(s[i] == "D"){
        totalsteps -=1;
    }
    else{
        totalsteps +=1;
        if (totalsteps == 0)
        {
            v+=1;
        }
    }
}
return v;

}

console.log(countingValleys(10, "DDUUDDUDUUUD"));