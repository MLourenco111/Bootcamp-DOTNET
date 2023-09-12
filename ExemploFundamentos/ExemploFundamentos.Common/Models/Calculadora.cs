using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Calculadora
    {
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        public void Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
        public void Multiplicar(int x, int y){
            Console.WriteLine($"{x} x {y} = {x * y}");
        } 
        public void Dividir(int x, int y){
            Console.WriteLine($"{x} / {y} = {x / y}");
        }  
        public void Potencia(int x, int y){
            double resultado = Math.Pow(x,y);
            Console.WriteLine ($"{x} ^ {y} = {resultado}");
        }

        public void Seno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double seno = Math.Sign(radiano);
            Console.WriteLine($"Seno de {angulo}° = {Math.Round(seno, 4)}");
        }
        public void Coseno(double angulo){
            double radiano = angulo * Math.PI / 180;
            double coseno = Math.Cos(radiano);
            Console.WriteLine($"Coseno de {angulo}° = {Math.Round(coseno, 4)}");
        }

        public void Tangente(double angulo){
            double radiano = angulo * Math.PI / 180;
            double tangente = Math.Tan(radiano);
            Console.WriteLine($"Tangente de {angulo}° = {Math.Round(tangente, 4)}");
        }
        public void RaizQuadrada(double x){
            double raiz =Math.Sqrt(x);
            Console.WriteLine($"A raiz quadrada de {x} é {raiz}");
        }
    }
}

//existe a classe math com operações para auxiliar e facilitar os calculos