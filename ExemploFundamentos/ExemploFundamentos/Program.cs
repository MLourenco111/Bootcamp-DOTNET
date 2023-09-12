// // See https://aka.ms/new-console-template for more information

using System.Diagnostics.Contracts;
using ExemploFundamentos.Common.Models;
//lista

List<string> listaString = new List<string>();
listaString.Add("SP");
listaString.Add("BA");
listaString.Add("MG");
Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
listaString.Add("PR");
Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");
listaString.Remove("MG");
Console.WriteLine($"Itens na minha lista: {listaString.Count} - Capacidade: {listaString.Capacity}");



for(int contador = 0; contador < listaString.Count; contador ++){
  Console.WriteLine($"Posição N° {contador} - {listaString[contador]}");
}

// //array
// int[] arrayInteiros = new int[3];
// arrayInteiros [0] = 10;
// arrayInteiros [1] = 1;
// arrayInteiros [2] = 29;

// //declarando um novo array com o tamanho dobrado e usando o metodo copy para copiar todos os elementos de outro array
// int[] arrayInteirosDobrados = new int[arrayInteiros.Length * 2];
// Array.Copy(arrayInteiros,arrayInteirosDobrados,arrayInteiros.Length);
// //resize serve para manipular o tamanho do array
// //Array.Resize(ref arrayInteiros,arrayInteiros.Length*2);

// Console.WriteLine("Percorrendo o Array com o  For");
// for(int contador = 0; contador < arrayInteiros.Length;contador++){
//     Console.WriteLine($"Posição N{contador} - {arrayInteiros[contador]}");
// }

// Console.WriteLine("Percorrendo o Array com o  Foreach");
// foreach(int valor in arrayInteiros){
//   Console.WriteLine(valor);
// }

// //Passando o caminho da classe (namespace)
// using System.ComponentModel.Design;
// using System.Net.Http.Headers;
// using System.Runtime.CompilerServices;
// using ExemploFundamentos.Common.Models;

// //criando uma instancia da classe Pessoa
// Pessoa p1 = new Pessoa();
// //adicionando valores para os atributos
// p1.Nome = "Matheus";
// p1.Idade = 23;
// //chamada de metodo
// p1.Apresentar();

// Console.WriteLine("-----------------------");
// // tipos de dados
// string frase = "Olá eu sou uma frase";
// int quantidade = 10;
// double altura = 1.70;
// decimal preco = 1.80M;
// bool condicao = true;


// Console.WriteLine(frase);
// Console.WriteLine("valor da quantidade " + quantidade);
// Console.WriteLine("valor da altura " + altura.ToString("0.00"));
// Console.WriteLine("valor da preco " + preco);
// Console.WriteLine("valor da condicao " + condicao);

// // tipo date time

//   DateTime dataAtual = DateTime.Now.AddDays(5).AddHours(10);
//   Console.WriteLine(dataAtual);
//   Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));


// //operadores
//   // = atribui um valor para a variavel


//  int a =10 , b= 10 , c=0;
//  c = a + b;
 
//  c = c + 5; // 20 + 5
//  // os dois fazer a mesma coisa de forma diferente
//  c += 5;// 25 + 5
//  c -= 5; // 30 - 5

//   Console.WriteLine(c);

//   //converter os tipos de variaveis
//   //a converção é chamada de casting      

//   int valor = Convert.ToInt32("5");
// //parse é universal para qualquer tipo de dados
//   int valor1 = int.Parse("5");

// // a diferenca entre convert e parse é o tratamento com o valor null, o convert converte para 0 e parse nao aceita nulo dando erro

//   Console.WriteLine(valor);
//   Console.WriteLine(valor1);

//   //casting para string
//   //para casting de string é usado ToString pois o metodo é derivado do obj que é o molde generico de todas as classes 
//   int inteiro = 130;
//   string s = inteiro.ToString();
//   Console.WriteLine(s);

//   //casting implicito que faz a conversao automaticamente
//   int z = 50;
//   double v = z;
//   Console.WriteLine(v);

//  // conversao de maneira segura
//  // metodo tryparse serve para uma conversao segura
//    string frase1 = "15=";
//    int numero = 0;

//    int.TryParse(frase1, out numero);
//    Console.WriteLine(numero);

// //condicao e debug

//     int quantidadeEmEstoque = 10;
//     int quantidadeCompra = 0;
//     bool possivelVenda = quantidadeCompra > 0 && quantidadeEmEstoque >= quantidadeCompra;

//     Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
//     Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
//     Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

//   if(quantidadeCompra == 0){
//     Console.WriteLine("Venda invalida");
//   }else if(possivelVenda){
//       Console.WriteLine("Venda realizada.");
//       quantidadeEmEstoque -= quantidadeCompra;
//     }else{
//       Console.WriteLine("Desculpe. Não temos a qunatidade desejada em estoque.");
//     }

// //switch case

//   Console.WriteLine("Digite uma letra: ");
//   string? letra = Console.ReadLine();
  
//   switch(letra){
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//       Console.WriteLine("Vogal");
//       break;
//     default:
//       Console.WriteLine("Não é uma vogal");
//       break;
//   }


// // operador OR
//   bool  maiorDeIdade = false;
//   bool possuiAltorizacaoResponsavel = false;

//   if (maiorDeIdade || possuiAltorizacaoResponsavel){
//     Console.WriteLine("Entrada liberada");
//   }else{
//     Console.WriteLine("Entrada não liberada");
//   }

// // operador AND
//   const int media = 7;
//   double nota = 7.1;
//   bool presencaMinima = false;
//   bool notaFinal = nota >= media;

//   if(presencaMinima && notaFinal){
//     Console.WriteLine("Aprovado!");
//   }else{
//     Console.WriteLine("Reprovado!");
//   }

//   //operador NOT

//   bool choveu = true;
//   bool estaTarde= false;

//   if( !choveu && !estaTarde){
//       Console.WriteLine("Vou pedalar");
//   }else{
//       Console.WriteLine("Vou pedalar outro dia");
//   }

// Calculadora calc = new Calculadora();
// calc.Somar(10,10);
// calc.Subtrair(20,100);
// calc.Multiplicar(1000, 100);
// calc.Dividir(8,8);
// calc.Potencia(10,5);
// calc.Seno(10);
// calc.Coseno(10);
// calc.Tangente(10);
// calc.RaizQuadrada(25);

// //incremento e decremento
// int numeroIncremento = 10;
// Console.WriteLine(numeroIncremento);
// Console.Write("Incrementando o 10");
// numeroIncremento++;

// Console.WriteLine(numeroIncremento);
// int numerodDecremento = 10;
// Console.WriteLine(numerodDecremento);
// Console.Write("Decrementado o 10");
// numerodDecremento--;
// Console.WriteLine(numerodDecremento);

// //estrutura for
// int x = 10;
// for(int contador = 0; contador <= 10; contador++){
//   Console.WriteLine($"{x * contador}");
// }


// //estrutura while
// x = 5;
// int cont = 0;
// while(cont <= 10){
//   Console.WriteLine($"{x * cont}");
//   cont++;
//   //ponto de parada com break
//     if(cont == 6){
//       break;
//     }
// }

// // estrutura do while

// int soma = 0 , num = 0;
// do{
//  Console.WriteLine("Digite um numero(0 para parar): "); 
//   num = Convert.ToInt32(Console.ReadLine());
//   soma += num;

// }while(num != 0);

// Console.WriteLine($"valor da soma {soma}");


// //Menu interativo

// string opcao;
// bool exibirMenu = true;

// while(exibirMenu){
//   Console.Clear(); //limpar o codigo do terminal
//   Console.WriteLine("Digite a sua opção: ");
//   Console.WriteLine("1 - Cadastras cliente");
//   Console.WriteLine("2 - Buscar cliente");
//   Console.WriteLine("3 - Apagar cliente");
//   Console.WriteLine("4 - Encerrar");

//   opcao = Console.ReadLine();

//   switch(opcao){
//     case "1":
//       Console.WriteLine("Cadastro de cliente");
//     break;
//     case "2":
//       Console.WriteLine("Busca de cliente");
//     break;
//     case "3":
//       Console.WriteLine("Apagar de cliente");
//     break;
//     case "4":
//       Console.WriteLine("Encerrar");
//       exibirMenu = false;
//       //Environment.Exit(0); //maneira de encerrar o processo / nao executa nada abaixo disso
//     break;

//     default:
//       Console.WriteLine("Opção invalida");
//     break;
//   }
// }

// Console.WriteLine("O programa se encerrou");