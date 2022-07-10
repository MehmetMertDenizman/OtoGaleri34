'use strict';
let tryer = 0;
let sum = 0;
while (tryer <= 2) {
    tryer++;
    let dolphinsPoint = prompt(parseInt("ENTER"), "DOLPHINS");
    let dolphinsPointAvg = parseInt(dolphinsPoint);

    sum += dolphinsPointAvg;
}

const calcAverage = calcAverage => sum / 3;
console.log(calcAverage(sum));

