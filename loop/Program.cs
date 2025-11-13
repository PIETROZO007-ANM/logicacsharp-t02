//loop for
for (int i = 1; i <= 10; i++) 
{
    Console.WriteLine(i);
}

//Soma dos numeros de 1 a 100

int soma = 0;
for (int i = 1; i <= 100; i++)
{
    soma += i;  //Soma o valor de i á variável soma, exemplo: 1+2+3+4..... até 100
}

Console.WriteLine("A soma dos números de 1 a 100 é: " + soma);

for (; ; )
{
    Console.WriteLine("Este é um loop infinito!");
}



//loop while (enquanto)

int contador = 1;
while (contador <= 5)
{
    Console.Write(contador);
    contador++; //incrementa o contador
}


//loop while (faça enquanto)
int novocontador = 2;

do
{
    Console.WriteLine(novocontador);
    novocontador++;
} while (novocontador <= 5);



//loop Infinito no while

while (true)
{
    Console.WriteLine("Este é um loop infinito!");
}



//loop foreach

//uma lista de strings
List<string> nomes = new List<string> { "ana", "carlos", "João", "maria", "pietro" };

//Usando o foreach para percorrer a lista
foreach (string nome in nomes) 
{
    Console.WriteLine(nome);
}


//Um vetor de numeros inteiros
int [] numeros = { 1, 2, 3, 4, 5 };
foreach (int numero in numeros)
{
    Console.WriteLine(numero);
}
