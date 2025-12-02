//Exercícios com array e foreach:


/*1.Faça um programa de listas de peças de carro
Crie um programa que tenha um array de nomes de 10 peças de carro e imprima
todos os nomes em uma lista*/


using System;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

string[] pecascarro =
{
            "Volante",
            "Rodas",
            "Suspensão",
            "Escapamento",
            "Retrovisor",
            "Farol",
            "Pneu",
            "Câmbio",
            "Filtro de ar",
            "Bateria"
};

Console.WriteLine("Lista das peças de carro: ");
foreach (string pecas in pecascarro)
{
    Console.WriteLine("-\n " + pecas);
}


Console.WriteLine("===================================================================");


/*2.Faça um programa de desconto
Crie um programa que tenha um array associativo com dados de um gato que
chegou no petshop, como chave e seu valor. Utilize o foreach para imprimir os
nomes dos dados do gato.*/


var gato = new Dictionary<string, string>()
{
            { "Nome", "Mingau" },
            { "Idade", "2 anos" },
            { "Raça", "Siamês" },
            { "Peso", "4 kg" },
            { "Cor", "Branco e cinza" },
            { "Status de saúde", "Saudável" },
            { "Procedência", "Resgatado" },
            { "Serviço solicitado", "Banho e tosa" },
            { "Tutor", "João" },
            { "Observações", "Muito dócil" }


};

Console.WriteLine("dados do pet: ");
foreach (var dado in gato)

{
    Console.WriteLine($"{dado.Key}: {dado.Value}");

}


Console.WriteLine("===================================================================");


//Exercícios com Do while:


/*1. Faça um programa que pergunte se a pessoa quer continuar
O programa pergunta se o usuário quer continuar digitando.
Enquanto ele responder “s”, o programa repete.*/

string sim = "s";
string nao = "n";

while (true)
{
    Console.WriteLine("escreva algo...");
    Console.ReadLine();
    Console.WriteLine("deseja continuar?  ");
    string escreva = Console.ReadLine();

    if (escreva == "s")
    {

    }
    else if (escreva == nao)
    {
        Console.WriteLine("encerrando...");
        return;
    }

}


Console.WriteLine("===================================================================");


/*2.Faça um programa de tabuada do 3
Crie um programa em C# que mostre a tabuada do número 3 de 1 a 10.
Use a estrutura do...while e declare a variável do contador já na mesma linha em
que ela é criada.
O programa deve exibir o resultado da multiplicação a cada repetição.*/


int i = 1; // contador declarado e inicializado na mesma linha
while (i <= 10)
{
    Console.WriteLine($"3 x {i} = {3 * i}");
    i++;
}
