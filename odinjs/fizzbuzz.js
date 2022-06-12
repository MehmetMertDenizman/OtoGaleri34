let userInput = window.prompt("Number?");
for (let i = 1; i <= userInput; i++){
    
if (userInput % 3 == 0){
    alert("Fizz!!!")

}
else if(userInput % 5 == 0){
        alert("Buzz!!!")    
    }
else if(userInput % 15 == 0){
    alert("Fizz Buzz!!!")}        
else{

alert("Pick another number")
let userInput = window.prompt("ANother Number")
            }}