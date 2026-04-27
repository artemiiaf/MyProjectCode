const hoursinput = document.querySelector("hours");
let rezult = hoursinput.value;
console.log(rezult);

const minutesinput = document.querySelector("minutes");
let rezult1 = minutesinput.value;
console.log(rezult1);

const secondinput = document.querySelector("seconds");
let rezult2 = secondinput.value;
console.log(rezult2);

let rovnohours = document.querySelector("lolhours");

let rovnominutes = document.querySelector("lolminutes");

let rovnoseconds = document.querySelector("lolseconds");

let inter = true;

let timeinput = document.querySelector("time");

let starttime = document.querySelector("start-time");

let stopt = document.querySelector("stop-time");

starttime.addEventListener("click", start);

stopt.addEventListener("click", stop);


function stop(seconds) {
   clearInterval(inter);
}

function start(inter) { setInterval(seconds, 1000);
     setInterval(seconds, 1000);
}

function seconds() {
  rovnoseconds.value = rezult2;

  rovnominutes.value = rezult1;

  rovnohours.value = rezult;

  rezult2--;
  console.log(rezult2 + " seconds");
  if (rezult2 < 1) {
    rezult2 = 59;
    rezult1--;

    console.log(rezult1 + " minutes");

    if (rezult1 < 1) {
      rezult1 = 59;
      rezult--;

      console.log(rezult + " hours");
      if (rezult < 0) {
        rezult = 23;
      }
    }
  }
}
