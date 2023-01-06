using Fundamentos_C_.Models;
using Newtonsoft.Json;


List<Vendas> listaVendas = new List<Vendas>();


Vendas v1 = new Vendas(1, "Material de escritório", 25.00M);
Vendas v2 = new Vendas(2, "Materia construção", 75.00M);

listaVendas.Add(v1);
listaVendas.Add(v2);
string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);
File.WriteAllText("Arquivos/vendas.json", serializado);
Console.WriteLine(serializado);






/*Pessoa p1 = new Pessoa("Dilan", "Lopez");
(string nome, string sobrenome) = p1;

Console.WriteLine($"{nome} {sobrenome}");

int numero = 20;
bool ehPar = false;

// com if térnario 
ehPar = numero % 2 == 0;
Console.WriteLine($"O número {numero} é " + (ehPar ? "par" : "ímpar"));
*/







/*
// sem if térnario
if (numero % 2 == 0)
{
  Console.WriteLine($"O número {numero} é par");
}
else
{
  Console.WriteLine($"O número {numero}  é impar");
}
*/











/*
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
  foreach (string linha in linhas)
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
catch (Exception ex)
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
foreach (int item in fila)
{
  Console.WriteLine($"Entrou na fila posição Nº {item}");
}
Console.WriteLine($"Saiu da Fila posição Nº {fila.Dequeue()}");
foreach (int item in fila)
{
  Console.WriteLine($"Fila atual Nº {item}");
}
// Collection Stack
Stack<int> pilha = new Stack<int>();
pilha.Push(3);
pilha.Push(6);
pilha.Push(9);
foreach (int item in pilha)
{
  Console.WriteLine($"Ordem da pilha {item}");
}
Console.WriteLine($"Saiu da ordem {pilha.Pop()}");
foreach (int item in pilha)
{
  Console.WriteLine($"Ordem atual Nº {item}");
}
// Dictionary
Dictionary<string, string> estados = new Dictionary<string, string>();
estados.Add("SP", "São Paulo");
estados.Add("BH", "Bahia");
estados.Add("MG", "Minas Gerais");
foreach (KeyValuePair<string, string> estado in estados)
{
  Console.WriteLine($"Chave: {estado.Key}, valor: {estado.Value}");
}
estados.Remove("BH");

estados["SP"] = "São Paulo Capital";

foreach (KeyValuePair<string, string> estado in estados)
{
  Console.WriteLine($"Chave: {estado.Key}, valor: {estado.Value}");
}


// tuplas 
(int, string, string, decimal) tupla = (1, "Dilan", "Lopez", 1.75M);
Console.WriteLine($"\n Id: {tupla.Item1}\n Nome: {tupla.Item2}\n Sobrenome: {tupla.Item3}\n Altura: {tupla.Item4}\n");
// metodo com tupla
LeituraArquivo arquivo = new LeituraArquivo();
// descarte com " _ "
var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");
if (sucesso)
{
  //Console.WriteLine($"Quantidade linhas do arquivo: {quantidadeLinhas}");
  foreach (string linha in linhasArquivo)
  {
    Console.WriteLine(linha);
  }
}
else
{
  Console.WriteLine("Não foi possivel ler o arquivo");
}
*/
