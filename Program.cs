using Fundamentos_C_.Models;

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