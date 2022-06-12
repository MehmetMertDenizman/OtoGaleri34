
    function add7(number){
        return number + 7
        
       
    }
    function multiply(n){
        return n*n
    }
    function capitalize(wordy){
        return wordy.charAt(0).toUpperCase() + wordy.slice(1); 
    }
    const capital = (say) => {
        return say
            .toLowerCase()
            .split(" ")
            .map(say => say.charAt(0).toUpperCase() + say.slice(1))
            .join(" ");
    }
    function capitaling(text){      
        var a = text.toLocaleLowerCase('TR').replace(/(^\w{1})|(\s{1}\w{1})/g, match => match.toLocaleUpperCase('TR'));
        return a

    }
