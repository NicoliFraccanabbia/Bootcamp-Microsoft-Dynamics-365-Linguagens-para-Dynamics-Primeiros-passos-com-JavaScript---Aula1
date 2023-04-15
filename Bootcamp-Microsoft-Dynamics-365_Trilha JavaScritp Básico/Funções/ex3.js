function incrementarJuros(valor, percentualJuros)//parâmetros
{
   const valordeAcrecimo = (percentualJuros / 100) * valor; 
   return valor + valordeAcrecimo;
}

console.log(incrementarJuros(100, 10));
console.log(incrementarJuros(100, 15));
console.log(incrementarJuros(100, 20));

