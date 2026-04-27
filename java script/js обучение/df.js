const btn = document.querySelector("#btn");
let str1 = ["q", "w", "e", "r", "t", "y", "u", "i", "o", "p"];
let nEl;
let resultStr = "";
let startTime;

function getRandomInt(max) {
  return Math.floor(Math.random() * max);
}

function randText() {
  for (let i = 0; i < 5; i++) {
    nEl = getRandomInt(str1.length - 1);
    console.log(nEl);

    resultStr += str1[nEl];
  }
}

function Name() {
  startTime = new Date();
  console.log(startTime.getMilliseconds());

  while (true) {
    randText();

    let str = prompt(`Введите ${resultStr}`);

    if (str === resultStr) {
      alert("Вы выйграли");
    } else if (str == 0) {
      break;
    } else {
      alert("Вы ошиблись");
    }
  }
}

btn.addEventListener("click", Name);
