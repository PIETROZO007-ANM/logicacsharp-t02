/*1. Saudação com Nome
Objetivo: Declarar variáveis, usar concatenação e interpolação.
Descrição: Crie um script que declare uma variável para o nome de
uma pessoa e exiba uma saudação personalizada, por exemplo: "Olá,
João! Bem-vindo ao nosso site!".
Dica: Utilize tanto a concatenação (.) quanto a interpolação dentro de
uma string com aspas duplas.*/



string nome = "João";

// concatenação
Console.WriteLine("Olá, " + nome + "! Bem-vindo ao nosso site!");

// interpolação
Console.WriteLine($"Olá, {nome}! Bem-vindo ao nosso site!");



/*2. Conversão de Temperatura (Celsius para Fahrenheit)
Objetivo: Trabalhar com cálculos matemáticos e variáveis.
Descrição: Crie um script que converta uma temperatura em Celsius
para Fahrenheit. A fórmula para conversão é:
Dica: Declare uma constante para armazenar o valor 9/5 e faça o
cálculo com a variável fornecida.*/




double celsius = 29; // Temperatura em Celsius
double fahrenheit = (celsius * 9 / 5) + 32; // Conversão
const double fator = 9.0 / 5.0;

Console.WriteLine($"{celsius}°C = {fahrenheit}°F\n");

Console.WriteLine("==== replicando pra decorar ====\n");

//replicando pra decorar
double celsiuss = 40; // Temperatura em Celsius
double fahrenheitt = (celsiuss * fator) + 32; // Conversão

Console.WriteLine($"{celsiuss}°C = {fahrenheitt}°F\n");

Console.WriteLine("===========================\n");


/*3. Impressão de Dados do Usuário
Objetivo: Concatenar e interpolar dados.
Descrição: Crie um script que solicite ao usuário seu nome, idade e
cidade e depois mostre uma mensagem com essas informações.
Exemplo: "Meu nome é João, tenho 25 anos e moro em São Paulo".
Dica: Use tanto concatenação quanto interpolação.*/



Console.WriteLine("qual o seu nome? ");
string nome = Console.ReadLine();
Console.WriteLine("\n");
Console.WriteLine("qual sua idade? ");
string idade = Console.ReadLine();
Console.WriteLine("\n");
Console.WriteLine("qual sua localidade? ");
string localidade = Console.ReadLine();
Console.WriteLine("\n");

Console.WriteLine($"seu nome é {nome} voce tem {idade} anos e mora em {localidade}");


/*4. Empréstimo Bancário
Objetivo: Cálculos financeiros e declaração de variáveis.
Descrição: Crie um script que calcule o valor de uma parcela de um
empréstimo, dado o valor total do empréstimo, a taxa de juros e o
número de parcelas. Exemplo de fórmula:
Dica: Utilize variáveis para o valor do empréstimo, a taxa de juros e o
número de parcelas.*/




// Declaração das variáveis
double valorEmprestimo, taxaJuros, valorParcela;
int numeroParcelas;

// Entrada de dados
Console.Write("Digite o valor total do empréstimo: R$ ");
valorEmprestimo = double.Parse(Console.ReadLine());

Console.Write("Digite a taxa de juros (ex: 0.05 para 5%): ");
taxaJuros = double.Parse(Console.ReadLine());

Console.Write("Digite o número de parcelas: ");
numeroParcelas = int.Parse(Console.ReadLine());

// Cálculo do valor da parcela
double valorTotalComJuros = valorEmprestimo + (valorEmprestimo taxaJuros);
valorParcela = valorTotalComJuros / numeroParcelas;

// Saída
Console.WriteLine($"\nValor total com juros: R$ {valorTotalComJuros:F2}");
Console.WriteLine($"Valor de cada parcela: R$ {valorParcela:F2}");

// Encerrar o programa
Console.WriteLine("\nPressione qualquer tecla para encerrar...");
Console.ReadKey();



/* 5.Conversor de Moeda 
Objetivo: Trabalhar com variáveis, operadores e arredondamento. 
Descrição: Crie um script que converta uma quantia em reais para 
dólares, com base em uma taxa de câmbio fornecida. Mostre o valor 
convertido com 2 casas decimais. 
Dica: Use round() para arredondar o valor para 2 casas decimais.*/


double valorEmReal = 1000.00; // mil reais
double taxaDeConversao = 5.60; // cinco e sessenta

double valorEmDólar = valorEmReal / taxaDeConversao;
double ArredondarValor = Math.Round(valorEmDólar, 2);

Console.WriteLine($"\nDinheiro em real: R$ {valorEmReal}");
Console.WriteLine($"Taxa: {taxaDeConversao}");
Console.WriteLine($"Dinheiro em dólar: {ArredondarValor}");


/*6 . Calculadora de Desconto
Objetivo: Cálculos matemáticos e uso de variáveis.
Descrição: Crie um script que calcule o valor do desconto de um
produto, dado o preço original e a porcentagem de desconto. Exemplo
de fórmula:
Dica: Use variáveis para armazenar o preço e a porcentagem do
desconto e calcule o valor final.*/


double precoOriginal = 400;
double porcentagemDesconto = 50;

double valorDesconto = precoOriginal * (porcentagemDesconto / 100);
double precoFinal = precoOriginal - valorDesconto;

Console.WriteLine($"Preço original: R$ {precoOriginal}");
Console.WriteLine($"Desconto: {porcentagemDesconto}%");
Console.WriteLine($"Valor do desconto: R$ {valorDesconto}");
Console.WriteLine($"Preço final: R$ {precoFinal}");