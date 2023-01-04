﻿using Fundamentos_C_.Models;

Pessoa p1 = new Pessoa(nome: "Dilan", sobrenome: "Lopez");

Pessoa p2 = new Pessoa(nome: "Elon", sobrenome: "Musk"); 

Curso cursoDeingles = new Curso();
cursoDeingles.Nome = "Inglês avançado";
cursoDeingles.Alunos = new List<Pessoa>();

cursoDeingles.InformacoesDoCurso();
cursoDeingles.AdicionarAluno(p1);
cursoDeingles.AdicionarAluno(p2);
cursoDeingles.ListarAlunos();
//p1.Idade = 22;
//p1.Apresentar();

// leitura de arquivos disparando erro com caminho de arquivo errado para exceção 
try
//tratando exceção
{
string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");
foreach(string linha in linhas) 
{
  Console.WriteLine(linha);
}
} 
//exceção especifica
catch (FileNotFoundException exception) 
{
  Console.WriteLine($"Exceção especifica {exception.Message}");
}
// generica
catch(Exception ex)
{
  Console.WriteLine($"Ocorreu uma exceção genérica\n {ex.Message}");
} 
finally
{
  Console.WriteLine("Leitura concluida");
}

// tratamento de exceção com throw

new ExemploExcecao().Metodo1();

// Collection Queue
Queue<int> fila = new Queue<int>();
fila.Enqueue(2);
fila.Enqueue(4);
fila.Enqueue(6);
foreach(int item in fila)
{
  Console.WriteLine($"Entrou na fila posição Nº {item}");
}
Console.WriteLine($"Saiu da Fila posição Nº {fila.Dequeue()}");
foreach(int item in fila)
{
  Console.WriteLine($"Fila atual Nº {item}");
}