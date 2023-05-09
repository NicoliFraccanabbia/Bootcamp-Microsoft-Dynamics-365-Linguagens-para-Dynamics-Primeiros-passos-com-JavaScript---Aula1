using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_explorando.Models
{
    public class Pessoa
    {
        public Pessoa()//podemos ter mais de um constutor com o mesmo nome, esse não recebe nada, fica como padrão
        {

        }
        //todo o construtor tem o mesmo nome da sua classe, neste caso recebe nome e sobrenome
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        private string _nome;  //criando um encapsulamento para armazenar 
        public string Nome
        {
            get
            {
                return _nome.ToUpper(); //retorna o nome todo com letras maiúsculas
            }
            ///ou a forma resumida  get => return _nome.ToUpper();

            set
            {
                if (value == "")//argumento que está recebendo o nome
                {
                    throw new ArgumentException("O nome não pode ser vazio");//tratamento de erro, para o código e não permite a execução
                }

                _nome = value;//se o value não for vazio o _nome recebe o nome
            }

        }//propriedade

        public string Sobrenome { get; set; }
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        private int _idade;  //criando um encapsulamento para armazenar 

        public int Idade
        {
            get => _idade;


            ///ou a forma resumida  get => return _idade;
            set
            {
                if (value < 0)//argumento que está recebendo a idade
                {
                    throw new ArgumentException("O idade não pode ser menor que zero");//tratamento de erro, para o código e não permite a execução
                }

                _idade = value;//se o value não for negativo, o _idade recebe a idade
            }

        }

        public void Apresentar()//método
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}