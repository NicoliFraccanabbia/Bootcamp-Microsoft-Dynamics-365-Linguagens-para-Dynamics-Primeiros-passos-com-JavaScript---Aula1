//variáveis boleanas se utiliza is na frente, é ou não é

const numero = 0;

const isNumeroDivisivelPor5 = (numero % 5) === 0; //para verificar se o número é divisivel por 5

// = atribuição  == igualdade, ignora o tipo  === igualdade, considerando o tipo

if (numero === 0) {   //se for verdadeiro executa essa condição
    console.log("O número é inválido");
}
else if (isNumeroDivisivelPor5) { //se essa for verdadeira para aqui, posso usar vários else if, não podemos usar só else no meio
    console.log("Sim");
}
else { // se os nateriores não forem verdadeiros cai nessa condição
    console.log("Não");

}