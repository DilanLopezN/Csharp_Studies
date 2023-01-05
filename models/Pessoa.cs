using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos_C_.Models
{
  public class Pessoa
  {
    public Pessoa()
    {

    }
    public Pessoa(string nome, string sobrenome)
    {
      Nome = nome;
      SobreNome = sobrenome;

    }

    private string _nome;
    private int _idade;


    public string Nome
    {
      get => _nome.ToUpper();


      set
      {
        if (value == "")
        {
          throw new ArgumentException("Nome não pode ser vazio");
        }
        _nome = value;
      }
    }
    public int Idade


    {
      get => _idade;

      set
      {
        if (value <= 0)
        {
          throw new ArgumentException("Idade deve ser maior que 0");
        }

        _idade = value;
      }
    }

    public string SobreNome { get; set; }

    public string NomeCompleto => $"{Nome} {SobreNome}".ToUpper();

    public void Apresentar()
    {
      Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
    }
  }
}