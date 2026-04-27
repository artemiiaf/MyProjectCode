let a = [2, 0, 10, 9, 28, 27, 31];
let b = [];
let key = a[0];
for (let i = 1; i < a.length; i++) {

  if (a[i] < key) {
    
  } else {
    b.push(a[i]);
    key = a[i];
  } 
}
console.log(b)
   
    