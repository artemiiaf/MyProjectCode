let x = +prompt("введите x ");

let a = +prompt("введите y ");

let b = +prompt("введите d ");

let f;

if ( 0 < x <= 1 ) {
 f = x - a / x, Math.sqrt(a) + Math.sin(x);
 let minEl = f;
 f = minEl;
} if ( x > 1 ) {
  f = Math.sqrt(x) , a * x;
  let maxEl = f; 
  f = maxEl;
} if ( x <= 0) {
  f = a * x + b;
}

console.log(f);