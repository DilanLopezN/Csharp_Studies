using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fundamentos_C_.models
{
    public class Livraria
    {
        public int InStock { get; set; }

        public string? Book { get; set; }


        public void BuyBook() {
            if(this.InStock <= 0) {
                Console.WriteLine("Livros insuficientes");
            } else {
                
                Console.WriteLine($"Livro {this.Book} comprado com sucesso");
            }
        }
    
    }
}