
var f = fib(15);
console.log(f);

function fib(num)
{
    if(num == 0) return 0;
    if(num == 1) return 1;
    if (num >= 2) {
      sum = fib(num - 1) + fib(num - 2);
  }
  return sum;
}

