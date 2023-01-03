using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos_C_.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public decimal valorDoCurso = 75.45M;

        public void AdicionarAluno(Pessoa aluno) 
        {
           Alunos.Add(aluno); 
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            int quantidade = Alunos.Count;
            return quantidade;
        }
        public bool RemoverAluno(Pessoa aluno)
        {
          return  Alunos.Remove(aluno);
        }
        
        public void ListarAlunos()
        {   
             Console.WriteLine($"Alunos matriculados:");
            for (int count = 0; count < Alunos.Count; count++)
            {
                // concatenação
                //string texto = "N° " + count + " - " + Alunos[count].NomeCompleto;
                // interpolação
                string texto = $"Nº {count + 1} - {Alunos[count].NomeCompleto}";
                 Console.WriteLine(texto);
            }
        }

        public void InformacoesDoCurso()
        {
            DateTime dataDeCobrança = DateTime.Now;
            string dataFormatada = dataDeCobrança.ToString($"08/MM/yyyy");
            Console.WriteLine($"Data da Mensalidade {dataFormatada}");
            Console.WriteLine($"Mensalidade do curso {valorDoCurso:C}");
            double porcentagemMultaAtraso = .0225;
            Console.WriteLine($"Multa de atraso de mensalidade - {porcentagemMultaAtraso.ToString("P")}");
        }

    }
}