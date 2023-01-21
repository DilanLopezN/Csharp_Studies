using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObjectOrientation.models;

namespace ObjectOrientation.models
{
  public class professor : Pessoa
  {
    public string Materia { get; set; }

    public void ApresentarProf()
    {
      Console.WriteLine($"O nome do professor é {this.Nome} ele tem {this.Idade} anos atualmente e da aula da matéria de {this.Materia}.\n");
    }

  }
}