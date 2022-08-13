f = (s, c = 0) => s > 9 ? f(eval([...s + ""].join`+`), ++c) : c
