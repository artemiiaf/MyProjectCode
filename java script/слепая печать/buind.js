const btn = document.querySelector("#btn");
console.log(btn);

let lettersAll = [
  "q",
  "w",
  "e",
  "r",
  "t",
  "y",
  "u",
  "i",
  "o",
  "p",
  "a",
  "s",
  "d",
  "f",
  "g",
  "h",
  "j",
  "k",
  "l",
  "z",
  "x",
  "c",
  "v",
  "b",
  "n",
  "m",
];
let letterUp = ["q", "w", "e", "r", "t", "y", "u", "i", "o", "p"];
let letterCenter = ["a", "s", "d", "f", "g", "h", "j", "k", "l"];
let letterDown = ["z", "x", "c", "v", "b", "n", "m"];

let randLtrs = ""; 
let word; 
let startTime;
let endTime;
let nEl;
let str;

btn.addEventListener("click", btnHandler);

/**
 * функция возвращает рандомное число по длине
 * @param {Number} max
 * @returns {Number}
 */
function getRandomInt(max) {
  return Math.floor(Math.random() * max);
}

function randomText(arrayLetters) {
  for (let i = 0; i < word; i++) {
    nEl = getRandomInt(arrayLetters.length - 1);
    randLtrs += arrayLetters[nEl];
  }
}
function menu(str) {
  switch (str) {
    case "1":
      randomText(letterUp);
      break;
    case "2":
      randomText(letterCenter);
      break;
    case "3":
      randomText(letterDown);
      break;
    case "all":
      randomText(lettersAll);
      break;
  }
}

function btnHandler() {
  word = prompt("из скольки символов вы хотите слово?");
  str = prompt("какую строчку клавиатуры выхотите использовать");

  startTime = new Date();

  menu();

  while (true) {
    let userInput = prompt(` Введите ${randLtrs} `);

    if (userInput == randLtrs) {
      endTime = new Date();
      alert(` правильно ${(endTime.getTime() - startTime.getTime()) / 1000}`);

      randLtrs = "";
      menu();

      startTime = new Date();
    } else if (userInput == "exit") {
      break;
    } else {
      alert("повторите попытку");
    }
  }
}


