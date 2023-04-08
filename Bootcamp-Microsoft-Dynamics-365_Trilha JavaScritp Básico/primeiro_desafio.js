/*Faça um programa para calcular o valor de uma viagem.
Você terá 3 variáveis. Sendo elas:

1 - preço do combustível;
2 - gasto médio de combustível do carro por KM;
3 - distância em km da viagem;

Imprima no console o valor que será gasto para realizar esta viagem.

*/
const precoCombustivel = 5.79; 
const distanciaDaViagemEmKm = 1580;
const gastoMediodeKmLitros = 12;

const litrosConsumidos = distanciaDaViagemEmKm / gastoMediodeKmLitros;
const valorGasto = litrosConsumidos * precoCombustivel;
console.log("O valor gasto na viagem foi: R$", valorGasto.toFixed(2)); // para converter para string e colocar as casas decimais



