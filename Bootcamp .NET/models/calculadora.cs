using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sintaxe_e_identação.models
{
    public class calculadora
    {
        public void somar(int y, int x){
            Console.WriteLine($"{x} + {y} = {x + y} " );
        }
        public void subtrair(int y, int x){
            Console.WriteLine($"{x} - {y} = {x - y} " );
        }
        public void multiplicar(int y, int x){
            Console.WriteLine($"{x} * {y} = {x * y}" );
        }
        public void divisao(int y, int x){
            Console.WriteLine($"{x} / {y} = {x / y} " );
        }
        public void Potencia(int y, int x){
            double Potencia =  Math.Pow(x,y);
            Console.WriteLine($"{x}^{y}= {Potencia} ");
        }
        public void seno(double angulo){
        double  radiano = angulo * Math.PI / 180;
        double seno = Math.Sin(radiano);
        Console.WriteLine($"Seno de {angulo} = {seno}  ");
        }
         public void coseno(double angulo){
        double  radiano = angulo * Math.PI / 180;
        double coseno = Math.Cos(radiano);
        Console.WriteLine($"coseeno de {angulo} = {coseno} ");
        }
         public void tangente(double angulo){
        double  radiano = angulo * Math.PI / 180;
        double tangente = Math.Tan(radiano);
        Console.WriteLine($"tangente de {angulo} = {tangente} ");
        }
        public void raizQuadrada ( double x){
           double  raiz = Math.Sqrt(x);
            Console.WriteLine($"raizQuadrada de {x} = {raiz} ");

        }
    }


}


