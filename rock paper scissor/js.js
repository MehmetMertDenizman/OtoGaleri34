let pick = ["rock", "paper", "scissor"];
function getComputerChoice()
{


    return console.log(pick[Math.floor(Math.random() * pick.length)]);

}
function mePick(a)
{
    console.log("You choose " + a);

}

let rock = document.querySelector("#Rock");
let paper = document.querySelector("#Paper");
let scissor = document.querySelector("#Scissor");
rock.addEventListener("onclick", mePick(rock))
paper.addEventListener("onclick", mePick(paper))
scissor.addEventListener("onclick", mePick(scissor))


//console.log(pick[Math.random()*pick.length()])
getComputerChoice();