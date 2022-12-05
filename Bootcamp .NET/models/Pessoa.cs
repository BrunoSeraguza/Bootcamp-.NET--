using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;





  namespace Sintaxe_e_identação.models
  {
     public class Pessoa
    {
            public string Nome { get; set; }
         public int Idade { get; set; }
        public string Faculdade { get; set; }
         public string Tecnologia { get; set; }
     public void Apresentar()
      {
       
         Console.WriteLine($"Olá, meu nome é {Nome}, "+
           $"tenho {Idade} anos, faço {Faculdade}, e vou dominar a plataforma {Tecnologia}! basta descomentar os codigos e rodar! ! ");
      }
      } 
  } 
 