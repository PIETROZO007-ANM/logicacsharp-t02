//Declaração de dois vetores
using System.Runtime.InteropServices;

int[] numeros = { 7, 2, 3, 34, 5 }; // Vetor de inteiros
string[] nomes = { "ana", "João", "Maria", "Carlos", };

//Exibindo os elementos do vetor de números com loop for
Console.WriteLine("Vetor de Números (usando for): ");
for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine(numeros[i]);
}

//Exibindo os elementos do vetor de nomes com loop foreach
Console.WriteLine("\nVetor de nomes (usando foreach):");
foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}

//Ordenação do vetor de números
Array.Sort(numeros);
Console.WriteLine("\nVetor de Números Ordenado:");
foreach (var n in numeros) 
{
    Console.WriteLine(n);
}

int valorprocurado = 5;
int posicaoSequencial = PesquisaSequencial(numeros, valorprocurado);

if (posicaoSequencial! > 1)
{
    Console.WriteLine($"\nPesquisa Sequencial: Valor {valorprocurado}encontrado na posição {posicaoSequencial}");
}
else
{
    Console.WriteLine($"\nPesquisa Sequencial: Valor {valorprocurado} não encontrado. ");
}

static int PesquisaSequencial(int[] vetor, int valor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        if (vetor[i]==valor)
             return i; 
    }
    return -1;
}