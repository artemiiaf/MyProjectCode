let cow;
let bull;


let namberStr = ['0','1','2','3','4','5','6','7','8','9'];

let nEl;
let randNumber;


let inputStr1 = document.querySelector('#number1');






function getRandomInt(max) {
    return Math.floor(Math.random() * max);
  }



  function randomNamber(arrayinputStr) {
      nEl = getRandomInt(arrayinputStr.length - 1);
      randNumber += arrayinputStr[nEl];
  }

