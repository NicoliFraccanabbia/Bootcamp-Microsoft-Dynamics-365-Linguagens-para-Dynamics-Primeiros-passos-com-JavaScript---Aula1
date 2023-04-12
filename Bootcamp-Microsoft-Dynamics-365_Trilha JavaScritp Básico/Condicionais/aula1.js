const numero = 6;

const isNumeroPar = (numero % 2) === 0; //para verificar se o número é par

// = atribuição  == igualdade, ignora o tipo  === igualdade, considerando o tipo

if (isNumeroPar) {   //se for true executa essa condição
    console.log("Par");
}

if (!isNumeroPar) {  //se não for par, ! serve para negar. Pode ser assim...
    console.log("Impar");
}

// ou
else {
    console.log("Impar");

}

