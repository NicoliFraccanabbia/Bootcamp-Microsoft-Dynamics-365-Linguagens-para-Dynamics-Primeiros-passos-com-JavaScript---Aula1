/* Faça um programa para calcular o valor de uma viagem.
Você terá 5 variáveis. Sendo elas:

1 - preço do etanol;
2 - preço da gasolina;
3 - o tipo de combustível que está no seu carro;
2 - gasto médio de combustível do carro por KM;
3 - distância em km da viagem;

Imprima no console o valor que será gasto para realizar esta viagem. */

const precoEtanol = 5.79;
const precoGasolina = 7.80;
const kmPorLitros = 10;
const distanciaEmKm = 100;
let tipoCombustivel = 'Etanol';

const litrosConsumidos = distanciaEmKm / kmPorLitros;

if (tipoCombustivel === 'Etanol') {
    const valorGasto = litrosConsumidos * precoEtanol;
    console.log("O valor gasto na viagem foi: R$", valorGasto.toFixed(2)); // para converter para string e colocar as casas decimais
}

else {
    const valorGasto = litrosConsumidos * precoGasolina;
    console.log("O valor gasto na viagem foi: R$", valorGasto.toFixed(2)); // para converter para string e colocar as casas decimais

}

