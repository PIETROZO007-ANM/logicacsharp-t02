//Teste de mesa]

double[] notas = { 7.5, 8.0, 6.5, 9.0, 7.0 };
double soma = 0;

Console.WriteLine("=== Teste de Mesa ===");
Console.WriteLine("| Passo |  i  | notas[i]  | soma antes | soma depois |");
Console.WriteLine("-------------------------------------------------------");

for (int i = 0; i < notas.Length; i++)
{
    double somaAntes = soma;
        soma += notas[i];
    double somaDepois = soma;

    Console.WriteLine($"| {i + 1,5} | {i,5} | {notas[i],8} | {somaAntes,10} | {somaDepois,11} |");
}

Console.WriteLine("-------------------------------------------------------");

double media = soma / notas.Length;
Console.WriteLine("A média das notas é: " + media);
Console.WriteLine();
