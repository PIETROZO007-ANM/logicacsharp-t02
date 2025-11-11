//condicional IF
using System;
using System.Collections;
using System.ComponentModel.Design;

string nome = "Ana";

if (nome == "Ana")
{
    Console.WriteLine("Olá, Ana!");
}


Console.WriteLine("============================================================================");


string texto = "";

if (string.IsNullOrEmpty(texto)) ;
{
    Console.WriteLine("A string está vazia. ");
}


Console.WriteLine("============================================================================");


//Condicional IF/ELSE
int idade = 16;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade");
}


Console.WriteLine("============================================================================");


int numero = 384;
if (numero % 2 == 0) 
{
    Console.WriteLine("O numero é par");
}

else
{
    Console.WriteLine("O numero é Impar");
}


Console.WriteLine("============================================================================");


//nota de escola

double nota = 6.5;

if (nota >= 9.0)
{
    Console.WriteLine("Voce obteve uma otima nota!");
}
else if (nota >= 7.0) 
{
    Console.WriteLine("Você está aprovado!");
}
else if (nota >= 5) 
{
    Console.WriteLine("Você está de recuperação");
}
else if (nota >= 3.0) 
{
    Console.WriteLine("Voce esta com risco de reprovação.");
}
else
{
    Console.WriteLine("Você foi reprovado.");
}


Console.WriteLine("============================================================================");


//PONTUAÇÃO

double pontuaçao = 9.5;
int faixanota = (int)Math.Round(pontuaçao);

switch (faixanota)
{
    case 10:
        Console.WriteLine("Você obtece uma excelente nota! Aprovado com distinção.");
        break;
    case 9:
    case 8:
        Console.WriteLine("Você está aprovado.");
        break;
    case 7:
    case 6:
        Console.WriteLine("Você está em recuperação.");
        break;
    case 5:
    case 4:
    case 3:
        Console.WriteLine("Você está com risco de reprovação.");
        break;
    default:
        Console.WriteLine("Você foi reprovado.");
        break;
}
ss