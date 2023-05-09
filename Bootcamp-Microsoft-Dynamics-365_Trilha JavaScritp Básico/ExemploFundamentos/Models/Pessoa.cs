using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


//devemos cuidar par não usar as palavras reservadas, se for extreamente necessário usar alguma palavra reservada, colocar @ na frente
namespace ExemploFundamentos.Models
{
    public class Pessoa
    {
        public string? Nome { get; set;}       
        public int Idade { get; set; }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");// podemos fazer quebra de linha adicionando as aspas e colocando + no final e abrindo aspas após novamente
        }
    }
}