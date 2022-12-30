using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos_C_.Models
{
    public class Pessoa
    {
        private string _nome;



        public string Nome 
        {
            get
            {
                return _nome.ToUpper();
            }

            set
            {
                if(value == "")
                {
                    throw new ArgumentException("Nome não pode ser vazio");
                }
                _nome = value;
            }
         }
        public int Idade { get; set; }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}