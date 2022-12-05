using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.models
{
   
         public class Calculadora
    {
        public void somar(int y, int x){
            Console.WriteLine($"{x} + {y} = {x} + {y}" );
        }
        public void subtrair(int y, int x){
            Console.WriteLine($"{x} - {y} = {x} - {y}" );
        }
        public void multiplicar(int y, int x){
            Console.WriteLine($"{x} * {y} = {x} * {y}" );
        }
        public void divisao(int y, int x){
            Console.WriteLine($"{x} / {y} = {x} / {y}" );
        }
    }
}
