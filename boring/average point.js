let rise = 0;
let sum = 0;
while (rise <= 2) {
    rise++;

    let average = prompt(parseInt("Enter"), "A TAKIMI");
    let average2 = parseInt(average)
    sum += average2;
    console.log(rise);

}

let result = parseInt(sum) / 3;
console.log("bu sum ", sum);
console.log("bu result ", result);

let riseB = 0;
let sumB = 0;
while (riseB <= 2) {
    riseB++;

    let averageB = prompt(parseInt("Enter"), "B TAKIMI");
    let average2B = parseInt(averageB)
    sumB += average2B;
    console.log(riseB);

}

let resultB = parseInt(sumB) / 3;
console.log("bu sum ", sumB);
console.log("bu result ", resultB);
if (result >= 100) {
    if (resultB >= 100) {
        if (result == resultB) {
            alert("EŞİTLER")
        }
        else if (result <= resultB) {
            alert("İkinci takım yendi");
        }
        else {
            alert("Birinci takım yendi");
        }
    }

} 
