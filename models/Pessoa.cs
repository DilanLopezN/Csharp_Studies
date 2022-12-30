using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos_C_.Models
{
    public class Pessoa
    {
        private string _nome;
        private int _idade;

        public string Nome 
        {
            get => _nome.ToUpper();
            

            set
            {
                if(value == "")
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
                    if(value <= 0) 
                    {
                        throw new ArgumentException("Idade deve ser maior que 0");
                    }
                    
                   _idade = value;
                } 
             }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }
    }
}