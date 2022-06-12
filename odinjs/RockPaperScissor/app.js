const scoreboard = {
    player: 0,
    ai: 0
  };
  const computerPick = ["rock", "paper", "scissors"];
  const score = document.getElementById("score");
  const rock_lis = document.getElementById("rock");
  const paper_lis = document.getElementById("paper");
  const scissors = document.getElementById("scissors");
  

  paper_lis.addEventListener("click", function () {
    game("paper");
  })
  scissors.addEventListener("click", function () {
    game("scissors");
  })
  rock_lis.addEventListener("click", function () {
        game("rock");
    })
  

function aiPick() {
   const rndNumber = Math.floor(Math.random() * 3);
   return computerPick[rndNumber]
}

function game(computerChoice){
    const aiChoice = aiPick();
    console.log(`ai choice is =>>> ${computerChoice}`);
}
function game_(userChoice){
    console.log(`User choice is =>>>${userChoice}`)
}





  /*
  buttons.forEach((button) => {
      button.addEventListener("click", function(){
          const pInput = this.textContent;
          const cInput = computerPick[Math.floor(Math.random()* computerPick.length)]
          compare(pInput, cInput);
      })
  })
  
  function compare(pInput, cInput){
      const currentMatch = `${pInput} vs ${cInput}`;
      if (pInput === cInput) {
          alert(`${currentMatch} is a Tie`);
          return;
        }
  }
  */
  