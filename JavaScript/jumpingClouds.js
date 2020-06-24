function jumpingOnClouds(c) {

    var jumps = 0;
for(var i = 0; i<c.length; i++){
    if(c[i+2] == 0 ){
            jumps++;
            i+=1;
        }
        else if(c[i+1] == 0){
            jumps ++;
            
        }
        else if(i == 0){
            jumps++;
        }
    }
return jumps;
}

console.log(jumpingOnClouds([0, 0, 1, 0, 0, 1, 0]))