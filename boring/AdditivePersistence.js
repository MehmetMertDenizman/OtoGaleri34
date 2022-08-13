AdditivePersistence = (num, i = 0) => num > 9 && num > 0 ?
    AdditivePersistence(eval([...num + ""].join`+`), ++i) : i



console.log(AdditivePersistence(0))