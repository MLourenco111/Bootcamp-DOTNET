// See https://aka.ms/new-console-template for more information
//Passando o caminho da classe (namespace)
using exemploFundamentos.Models;

//criando uma instancia da classe Pessoa
Pessoa p1 = new Pessoa();
//adicionando valores para os atributos
p1.Nome = "Matheus";
p1.Idade = 23;
//chamada de metodo
p1.Apresentar();

Console.WriteLine("-----------------------");
// tipos de dados
string frase = "Olá eu sou uma frase";
int quantidade = 10;
double altura = 1.70;
decimal preco = 1.80M;
bool condicao = true;


Console.WriteLine(frase);
Console.WriteLine("valor da quantidade " + quantidade);
Console.WriteLine("valor da altura " + altura.ToString("0.00"));
Console.WriteLine("valor da preco " + preco);
Console.WriteLine("valor da condicao " + condicao);

// tipo date time

  DateTime dataAtual = DateTime.Now.AddDays(5).AddHours(10);
  Console.WriteLine(dataAtual);
  Console.WriteLine(dataAtual.ToString("dd/MM/yyyy"));


//operadores
  // = atribui um valor para a variavel


 int a =10 , b= 10 , c=0;
 c = a + b;
 
 c = c + 5; // 20 + 5
 // os dois fazer a mesma coisa de forma diferente
 c += 5;// 25 + 5
 c -= 5; // 30 - 5

  Console.WriteLine(c);

  //converter os tipos de variaveis
  //a converção é chamada de casting      

  int valor = Convert.ToInt32("5");
//parse é universal para qualquer tipo de dados
  int valor1 = int.Parse("5");

// a diferenca entre convert e parse é o tratamento com o valor null, o convert converte para 0 e parse nao aceita nulo dando erro

  Console.WriteLine(valor);
  Console.WriteLine(valor1);

  //casting para string
  //para casting de string é usado ToString pois o metodo é derivado do obj que é o molde generico de todas as classes 
  int inteiro = 130;
  string s = inteiro.ToString();
  Console.WriteLine(s);

  //casting implicito que faz a conversao automaticamente
  int z = 50;
  double v = z;
  Console.WriteLine(v);

 // conversao de maneira segura
 // metodo tryparse serve para uma conversao segura
   string frase1 = "15=";
   int numero = 0;

   int.TryParse(frase1, out numero);
   Console.WriteLine(numero);

//condicao e debug

    int quantidadeEmEstoque = 10;
    int quantidadeCompra = 4;
    bool possivelVenda = quantidadeEmEstoque >= quantidadeCompra;

    Console.WriteLine($"Quantidade em estoque: {quantidadeEmEstoque}");
    Console.WriteLine($"Quantidade de compra: {quantidadeCompra}");
    Console.WriteLine($"É possivel realizar a venda? {possivelVenda}");

    if(possivelVenda){
      Console.WriteLine("Venda realizada.");
      quantidadeEmEstoque -= quantidadeCompra;
    }else{
      Console.WriteLine("Desculpe. Não temos a qunatidade desejada em estoque.");
    }
