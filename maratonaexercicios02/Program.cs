//Exercícios com if, else e elseif:

/*1. Faça um programa para verificação de estoque
Um sistema de gerenciamento de estoque precisa notificar os funcionários
quando for hora de reabastecer um produto.
Escreva um código que verifique a quantidade de um produto em estoque. Se a
quantidade for menor que 5, exiba a mensagem: "Alerta: Baixo estoque. Por favor,
reabasteça este produto.". Caso contrário, exiba: "Estoque suficiente."*/




int produtosestoque = 4;
if (produtosestoque >= 5)
{
    Console.WriteLine("estoque suficiente.");
}
else if (produtosestoque <= 4)
{
    Console.WriteLine("Alerta: Baixo estoque. por favor, reabasteça este produto.");
}


Console.WriteLine("=========================================================");


/*2. Faça um programa de desconto
Uma loja oferece um desconto para compras acima de um certo valor como parte
de uma promoção de vendas. Escreva um código que determine o valor total da
compra de um cliente. Se o valor total for superior a R$ 200,00, aplique um
desconto de 10% e exiba: "Desconto de 10% aplicado!". Se o valor total for R$
200,00 ou menos, informe: "Adicione mais itens ao carrinho para ganhar um
desconto de 10%.". */




double produto = 200;

if (produto >= 200)
{
    Console.WriteLine($"desconto de 10% aplicado! ");
}
else if (produto < 200)
{
    Console.WriteLine($"adicione mais itens ao carrinho para ganhar um desconto de 10%.");
}


Console.WriteLine("=========================================================");


//Exercícios com switch:

/*1. Faça um programa que determine o dia da semana
O programa deve receber um número de 1 a 7, representando um dia da semana,
e imprimir o nome do dia correspondente (por exemplo, 1 = "Domingo", 2 =
"Segunda-feira", etc.).*/




int dias = 7;
switch (dias)
{
    case 1:
        Console.WriteLine("domingo");
        break;
    case 2:
        Console.WriteLine("segunda");
        break;
    case 3:
        Console.WriteLine("terça");
        break;
    case 4:
        Console.WriteLine("quarta");
        break;
    case 5:
        Console.WriteLine("quinta");
        break;
    case 6:
        Console.WriteLine("sexta");
        break;
    case 7:
        Console.WriteLine("sábado");
        break;
}


Console.WriteLine("=============================================================");


/*2. Faça um programa que calcule o preço final de um produto com base em um
código de desconto
O programa deve receber um código de desconto (de 1 a 3) e aplicar o desconto
correspondente ao preço do produto.
o Código 1: 10% de desconto
o Código 2: 20% de desconto
o Código 3: 30% de desconto
o Se o código for inválido, deve mostrar uma mensagem de erro.*/




//Para o atendimento do caixa exemplo:
Console.Write("Preço do produto: R$ ");
double preco = double.Parse(Console.ReadLine().Replace(',', '.')); // aceita vírgula ou ponto

Console.Write("Código de desconto (1=10%, 2=20%, 3=30%): ");
int codigo = int.Parse(Console.ReadLine());

double percentual;

switch (codigo)
{
    case 1: percentual = 0.10; break;
    case 2: percentual = 0.20; break;
    case 3: percentual = 0.30; break;
    default:
        Console.WriteLine("Código inválido. Use 1, 2 ou 3.");
        return;
}

double desconto = preco * percentual;
double final = preco - desconto;

Console.WriteLine($"\nDesconto: {percentual * 100}%");
Console.WriteLine($"Valor do desconto: R$ {desconto:F2}");
Console.WriteLine($"Preço final: R$ {final:F2}");


Console.WriteLine("=============================================================");


//Exercícios com for:

/*1. Faça um programa de tabuada de multiplicação
Crie um programa que mostre na tela as tabuadas do número 7, utilizando laço de
repetição for.
O programa deve exibir, para cada número de 7, a multiplicação desse número
pelos valores de 1 a 10.*/




int numero = 7;//Número que vai ser usado pra multiplicação.

Console.WriteLine("tabuada de multiplicaçao do numero 7:\n");

for (int i = 1; i < 11; i++) //armação da lista de 1 a 10
{
    int resultado = numero * i;
    Console.WriteLine($"{numero} x {i} = {resultado}");
}


Console.WriteLine("=============================================================");


/*2.Faça um programa para calcular a média
Crie um programa que receba 10 números inteiros e calcule a média desses
números. Utilize o laço for para ler os números e calcular a média.*/




for (int i = 1; i < 11; i++)
{

    Console.WriteLine("Escreva as médias dos dez alunos: ");
    int nota = int.Parse(Console.ReadLine());


    if (nota >= 9)
    {
        Console.WriteLine("Você obteve uma ótima nota!");
    }
    else if (nota >= 7)
    {
        Console.WriteLine("Você está aprovado!");
    }
    else if (nota >= 5)
    {
        Console.WriteLine("Você está de recuperação.");
    }
    else if (nota >= 3)
    {
        Console.WriteLine("Você está com risco de reprovação.");
    }
    else
    {
        Console.WriteLine("Você foi reprovado.");
    }
}


Console.WriteLine("=============================================================");


//Exercícios com while:

/*1.Faça um programa contador de visitantes
Desenvolva um código que simula a entrada X visitantes aleatoriamente no
museu. A capacidade máxima é de 50 pessoas. Use um loop while para "contar"
cada visitante até que a capacidade máxima seja atingida. A cada visitante
adicional, exiba o número total de visitantes até o momento.*/




int entradaDeVisitantes = 1;

do
{
    Console.WriteLine($"Número total de visitantes até o momento: {entradaDeVisitantes}");
    entradaDeVisitantes++;
}
while (entradaDeVisitantes <= 50); // se for menor que 50 continue


Console.WriteLine("=============================================================");


/*2. Faça um programa de sistema de login
Um sistema de login precisa verificar a autenticidade do usuário, permitindo
múltiplas tentativas até que as credenciais corretas sejam fornecidas.
Desenvolva um código que simule um sistema de login usando um loop while. O
usuário tem um máximo de 3 tentativas para inserir a senha correta. Se a senha
correta ("senha123") for inserida, exiba "Login bem-sucedido!". Se o limite de
tentativas for atingido, mostre "Conta bloqueada por excesso de tentativas.".*/




string senha_correta = "senha123";
int tentativas = 0;
int maxdetentativas = 3;

while (tentativas < maxdetentativas)
{
    Console.WriteLine("Digite sua senha: ");
    string senhaDigitada = Console.ReadLine();

    if (senhaDigitada == senha_correta)
    {
        Console.WriteLine("Login bem sucedido!");
        return;
    }
    else
    {
        tentativas++;
        Console.WriteLine($"Senha incorreta. Tentativas restantes {maxdetentativas - tentativas}");
    }
}
Console.WriteLine("Conta bloqueada por excesso de tentativas.");s