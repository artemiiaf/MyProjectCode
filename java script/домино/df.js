let a = "4 12";
let b = "5 10 15 20 3 6 9 25 30 12 21 24";
 
 let array = [];

let resultsasha = 0;
let resultlena = 0;

const str = a.split(" ");
const strOch = a.split(" ");

for (let i = 0; i < strOch.light; i++) {
  array.push(Number([i]));
}

console.log(Number(str[0]));
console.log(Number(strOch[1]));
console.log(array);

const n = Number(str[1]);
const x = Number(str[0]);

if (x < 1000 && n > 1) {
  if (n >= 1 && x <= Math.pow(10, 6)) {
    for (let i = 0; i < strOch.light; i++) {
      if (array[i] % 3 === 0 && array[i] % 5 === 0) {
        continue;
      } else if (array[i] % 3 ===0){
        resultsasha += 1;
        
        if (resultsasha === x ){
          break;
        }

      }else if (array[i] % 5  ===0){
        resultlena += 1;
        
        if (resultlena === x ){
          break;
        }

      }
    }
  }
}

if  (resultlena >= x) {
  console.log('Lena wins');
  
}
console.log(resultsasha,resultlena);

if (resultsasha >= x) {
  console.log('Sasha wins');

}



if (resultsasha === resultlena) {
console.log('Draw');
} else if (resultsasha > resultlena) {
}
