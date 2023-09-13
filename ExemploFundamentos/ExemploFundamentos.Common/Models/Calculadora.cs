using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploFundamentos.Common.Models
{
    public class Calculadora
    {
        /// <summary>
        ///     Realiza a soma de dois numeros
        /// </summary>
        /// <param name="x">o primeiro numero inteiro para somar</param>
        /// <param name="y">o segundo numero inteiro para somar</param>
        public void Somar(int x, int y){
            Console.WriteLine($"{x} + {y} = {x + y}");
        }
        /// <summary>
        /// Realiza uma substração de dois valores
        /// </summary>
        /// <param name="x">primeiro valor inteiro</param>
        /// <param name="y">segundo valor inteiro</param>
        /// <returns>retorna o resultado com um valor inteiro</returns>
        public int Subtrair(int x, int y){
            Console.WriteLine($"{x} - {y} = {x - y}");
            return x - y;
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