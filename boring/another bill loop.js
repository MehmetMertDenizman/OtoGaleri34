'use strict';
//let age = 11;

//console.log(age >= 18 ? console.log("Geber amk 18den büyük") : console.log("Aboo küçük"));

let re = 0;
let bills = [];
let billtip = [bills];
while (re <= 2)
{
    re++;
    bills.push(prompt(Number("Gir"), "Ödeme gir"));

}
for (let i = 0; i in bills; i++)
{
    if (bills[i] >= 50 && bills[i] <= 300)
    {
        billtip.push(bills[i] * 0.15);
    }
    else
    {
        billtip.push(bills[i] * 0.20);
    }
}
console.log("Ödemeler " + bills);
var newData = bills.map(function (bills) { return bills * 0.15 });
console.log("Tip miktarı " + billtip);
console.log("Tip miktarı map ile " + newData);

// let i = 0;
// for (i = 0; i in bills; i++)
// {
//     while (i <= re)
//     {

//         i++;
//         if (bills[i] >= 50 && bills[i] <= 300)
//         {
//             bills.push([i]) * 0.15;
//         }
//         else
//         {
//             bills.push([i]) * 0.20;
//         }


//     }
//     console.log(bills[i]);
//}

// let tip = bill;
// bill >= 50 && bill <= 300 ? tip = tip * 0.15 : tip = tip * 0.20;
// let res = tip + bill;
// console.log(Number(bill) + Number(tip));

