let x = [-1.5, 0.1, 12, 0, -2.2, 0.5, -1, 0.3];
let minEl = x[0];
let maxEl = x[0];

for (let i = 1; i < x.length; i++) {
  if (minEl > x[i]) {
    minEl = x[i];
  }
}
for (let i = 0; i < x.length; i++) {
  if (x[i] < 0) {
    x[i] = minEl;
    
  }
}
for (let i = 1; i < x.length; i++) {
    if (maxEl < x[i]) {
      maxEl = x[i];
    }
  }
  for (let i = 0; i < x.length; i++) {
    if (x[i] > 0) {
      x[i] = maxEl;
      
    }
  }
console.log(x);

