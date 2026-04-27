' use strict'

let x = +prompt("enter x = ")
let y = +prompt("enter y = ")


let t = Math.cos(Math.PI / 7) * (Math.pow(Math.sin(x - (8 * y)), 2) / 2.7 * (x - Math.PI));
console.log(t) 
alert(t) 