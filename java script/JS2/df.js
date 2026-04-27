" use strict";
// вариант такой-то
let x = +prompt("введите x ");

let y = +prompt("введите y ");

let d = +prompt("введите d ");

let c = +prompt("введите c ");

let r;

if (x > 1 && y > 2) {
  r = x * Math.sqrt(Math.pow(d * y, 3));
} else if (x < 0) {
  let minEl = y;
  if (minEl < x) {
    minEl = X;
  }
  if (minEl < c) {
    minEl = c;
  }
  r = minEl;
} else {
  let maxEl = Math.pow(lg, 2) * d * x;
  if (maxEl < Math.pow(y * c, 2)) {
    maxEl = Math.pow(y * c, 2);
  }
  r = maxEl;
}
console.log(r);
