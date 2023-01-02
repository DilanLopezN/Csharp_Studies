using Fundamentos_C_.Models;

Pessoa p1 = new Pessoa();

p1.Nome = "Dilan";
p1.SobreNome = "Lopez";

Pessoa p2 = new Pessoa();

p2.Nome = "Elon";
p2.SobreNome = "Musk";

Curso cursoDeingles = new Curso();
cursoDeingles.Nome = "Inglês avançado";
cursoDeingles.Alunos = new List<Pessoa>();

cursoDeingles.AdicionarAluno(p1);
cursoDeingles.AdicionarAluno(p2);
cursoDeingles.ListarAlunos();


//p1.Idade = 22;
//p1.Apresentar();