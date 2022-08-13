
// const anan = {
//     name: "Mert",
//     sur: "Denizman",
//     age: 30,
//     mass: 75,
//     height: 175,
//     calc: function () { return this.mass / (this.height ** 2) * 10000 }

// };
// const eben = {
//     name: "Eben",
//     sur: "Denizman",
//     age: 30,
//     mass: 66,
//     height: 155,

//     calc: function () { return this.mass / (this.height ** 2) * 10000 }
// };



// console.log(eben.calc());
// console.log(anan.calc());

//-----------------------------------------------------------------

let bills = [22, 295, 176, 440, 37, 105, 10, 1100, 860, 52];
let tips = [];
let totals = [];

for (let i = 0; i < bills.length; i++)
{
    console.log(bills[i]);
    calcTip = () => bills[i] > 50 && bills[i] < 300 || bills[i] < 50 ? tips.push(bills[i] * 0.15) : tips.push(bills[i]) * 0.15;
    calcTip()
    console.log(tips[i]);

}
