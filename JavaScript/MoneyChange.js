fizbuzz(100);

change(69);
console.log("The end");

function fizbuzz(max) {
  for (var i = 1; i <= max; i++)
  {
    if (i % 3 === 0 && i % 5 === 0) {
      console.log("fizz buzz");
    }
    if (i % 3 === 0 ) {
      console.log("fizz ");
    }
    else if ( i % 5 === 0) {
      console.log("buzz");
    }
    else {
      console.log(i);
    }

  }
  }


function change(num) {
  console.log("Calculanting change for:" + num);

  var change = [[ 25, 0 ], [ 10, 0 ], [ 5, 0 ], [1,0]];

  for (var i = 0; i < change.length; i++) {
    var coinValue = change[i][0];
    if (num > coinValue) {
      change[i][1] = Math.floor(num / coinValue);
      num = num - (change[i][1] * coinValue);
    }
  }
  console.log(change);

}
