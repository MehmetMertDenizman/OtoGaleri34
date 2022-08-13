let pick = ["rock", "paper", "scissor"];
function getComputerChoice()
{


    return console.log(pick[Math.floor(Math.random() * pick.length)]);

}


//console.log(pick[Math.random()*pick.length()])
getComputerChoice();