using Exemplo_explorando.Models;
using System;
using System.Collections.Generic;
using System.Globalization; //para acessar a locaçização

Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("RS", "Rio Grande do Sul");//primeiro valor é a chave
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

System.Console.WriteLine(estados["MG"]); // para acessar o valor 




// foreach(KeyValuePair<string, string> item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }
// estados["RS"] = "Rio Grande do Sul - valor alterado";//para alterar um valor
// estados.Remove("BA"); //para remover um elemento

// foreach(KeyValuePair<string, string> item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA2";
// System.Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave)) //para verificar se uma chave já foi adicionada
// {
//     System.Console.WriteLine($"Valor existente: {chave}");

// }
// else
// {
//     System.Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }




// Stack<int> pilha = new Stack<int>(); //para criar uma pilha

// pilha.Push(4);//adicionando elementos na pilha
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach(int item in pilha)//laço para percorrer a pilha
// {
//     System.Console.WriteLine(item);
// }

// System.Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}"); 

// pilha.Push(20);

// foreach(int item in pilha)//laço para percorrer a pilha
// {
//     System.Console.WriteLine(item);
// }




// Queue<int> fila = new Queue<int>();//criando uma fila

// fila.Enqueue(2); //adicionando elementos na fila
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach(int item in fila)//para percorrer a fila
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); //para remover elementos, sempre remove o primeiro elemento
// fila.Enqueue(10);//adicionando mais um elemento

// foreach(int item in fila)//para percorrer a fila
// {
//     Console.WriteLine(item);
// }





// new ExemploExcecao().Metodo1();



















// try//significa "tente", vai executar o bloco
// {
// string[] linhas = File.ReadAllLines("Arquivos/arquivoLeitura.txt");

// foreach(string linha in linhas)
// {
//     Console.WriteLine(linha);
// }
// } catch(Exception ex)//catch: pegar, obter. 
// {
//     Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally//serve para executar um bloco de código independente se acontecer ou não exceção
// {
//     Console.WriteLine("Chegou até aqui");
// }













// DateTime data = DateTime.Now;//pega a data do sistema
// System.Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));//é possivel formatar/personalizar como quer imprimir 




















//CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR"); //para forçar o sistem  ter uma localização diferente

//decimal valorMonetario = 1582.40M; //precisa colocar o M no final para o sistema reconhecer que é decimal

//System.Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));//força a formatar em dólar mesmo depois de definir a cultura anteriormente

//double porcentagem = .3421;
//System.Console.WriteLine(porcentagem.ToString("P"));

//int numero = 123456;
//System.Console.WriteLine(numero.ToString("##-##-##"));







//using System.Collections.Generic;


//string numero1 = "10";
//string numero2 = "20";

//string resultado = numero1 + numero2;

//System.Console.WriteLine(resultado);

















//Pessoa p1 = new Pessoa(nome: "Nicoli", sobrenome: "Rama");
//Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves");


//Curso cursoDeIngles = new Curso();
//cursoDeIngles.Nome = "Inglês";
//cursoDeIngles.Alunos = new List<Pessoa>();

//cursoDeIngles.AdicionarAluno(p1);
//cursoDeIngles.AdicionarAluno(p2);
//cursoDeIngles.ListarAlunos();



















///Pessoa p1 = new Pessoa();
///p1.Nome = "Nicoli";
///p1.Sobrenome = "Rama";
///p1.Idade = 10;
///p1.Apresentar();