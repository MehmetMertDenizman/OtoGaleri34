'use strict';
let tryer = 0;
let sum = 0;
while (tryer <= 2)
{
    tryer++;
    let dolphinsPoint = prompt(parseInt("ENTER"), "DOLPHINS");
    let dolphinsPointAvg = parseInt(dolphinsPoint);

    sum += dolphinsPointAvg;
}




let tryer2 = 0;
let sum2 = 0;

while (tryer2 <= 2)
{
    tryer2++;
    let koalasPoint = prompt(parseInt("GİRRR"), "KOALA");
    let koalasPointAvg = parseInt(koalasPoint);
    sum2 += koalasPointAvg;
}

const calcAverage = (x) => x / 3;
console.log(calcAverage(sum));
console.log(calcAverage(sum2));
if (sum * 2 < sum2)
{
    console.log("Koala win");


}
else if (sum > sum2 * 2)
{
    console.log("Dopl win");
}
else { console.log("Ulan yenen yok"); }