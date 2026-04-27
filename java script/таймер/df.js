let timeinput = document.querySelectorAll(.time);
let btn1 = document.querySelector('#start');
let btn2 = document.querySelector('#stop');
let h1 = document.querySelector('#outputtext');

console.log(h1)

btn1.addEventListener('click', startTime);
btn2.addEventListener('click', stopTime);



let inter;
let text;
let h;
let m;
let s;

function _changeTimer() {

    if (s === 0) {
        if (m === 0) {
            if (h === 0) {
                clearInterval(inter);
            } else {
                h--;
                m = 59;
                s = 59;
            }
        }
    } else if (s < 0) {
        if(m > 0){
            m--;
            s = 59;
        } else {
            if(h == 0)
            {
                clearInterval(inter);
            } else{
                h--;
                m = 59;
                s = 59;
            }
        }
    }
}

function startTime() {
    btn1.disabled = true;
    h = +timeinput[0].value || 0;
    m = +timeinput[1].value || 0;
    s = +timeinput[2].value || 0;

    if (s == 0) {
        s++;
    }

    inter = setInterval(() => {
        s--;
        _changeTimer()
        h1.innerHTML = h + " : " + m + " : " + s;
    }, 1000);



    h1.innerHTML = text;
}

function stopTime() {
    btn1.disabled = false;
    clearInterval(inter)
}



function _checkTimer(h, m, s) {
    if (h == 0 && m == 0 && s == 0) {
        return true;
    } else {
        return false;
    }
}