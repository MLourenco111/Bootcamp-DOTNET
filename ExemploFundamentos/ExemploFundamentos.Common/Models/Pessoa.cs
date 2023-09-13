using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

//uma organizacao das suas classes, representa um caminho logico que esteja no mesmo dominio
namespace ExemploFundamentos.Common.Models{
    /// <summary>
    /// Representa uma pessoa fisica
    /// </summary>
    public class Pessoa{
        // atributos da classe pessoa 
        public string? Nome { get; set; } //get serve para pegar um valor, set para atribuir valor
        public int Idade { get; set; }
        public string? NomeRepresentanteLegal { get; set; } 
        
        // metodos da classe pessoa
        /// <summary>
        /// Faz a pessoa se apresentar dizendo seu nome e idade
        /// </summary>
        public void Apresentar(){
        // comando para escrever no terminal
        Console.WriteLine($"Olá, meu nomé é {Nome}, e tenho {Idade} anos");
        }
    }
}



// @ permite a atribuicao de palavras reservadas da maneira que quiser
//É possivel ter mais de uma classe com o mesmo nome, mas o namespace deve ser diferente
// PascalCase é usado em classes, metodos e atributos e camelCase é usado nas variaveis