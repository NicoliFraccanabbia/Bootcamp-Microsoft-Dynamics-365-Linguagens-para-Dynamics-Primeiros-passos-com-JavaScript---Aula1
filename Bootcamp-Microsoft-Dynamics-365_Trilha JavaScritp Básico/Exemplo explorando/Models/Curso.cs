using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exemplo_explorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno(Pessoa aluno)//void não retorna nada(vazio)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()//tem retorno, obrigatório ter return
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }

        public void RemoverAluno(Pessoa aluno)//remove o aluno da lista
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            Console.WriteLine($"Alunos do curso de: {Nome}");

            for (int count = 0; count < Alunos.Count; count++)//vai demonstrar a posição atual ao percorrer a lista
            {
                //string texto = "Nº " + count + " - " + Alunos[count].NomeCompleto; -->concatenação de strings
                string texto = $"Nº {count + 1} - {Alunos[count].NomeCompleto}"; //interpolação de strings
                Console.WriteLine(texto);
            }
        }
    }
}