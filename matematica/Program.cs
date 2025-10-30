//Declarando constantes
const int valor1 = 10;
const int valor2 = 5;

//Soma
int soma = valor1 + valor2;
Console.WriteLine($"Soma: {valor1} + {valor2} = {soma}");

//Subtração
int subtracao = valor1 - valor2;
Console.WriteLine($"Subtração: {valor1} - {valor2} = {subtracao}");

//multiplicação
int multiplicacao = valor1 * valor2;
Console.WriteLine($"Multiplicação: {valor1} * {valor2} = {multiplicacao}");

//Divisão
int divisao = valor1 / valor2;
Console.WriteLine($"divisão: {valor1} / {valor2} = {divisao}");

//Resto da divisão
int RestoDaDivisao = valor1 % valor2;
Console.WriteLine($"divisão: {valor1} / {valor2} = {RestoDaDivisao}");

//potenciação(usando math para calcular a potencia)
double potencia = Math.Pow(valor1, valor2);
Console.WriteLine($"Pontenciação: {valor1} elevado a {valor2} = {potencia}");

/* (comentario mais de 1 linda ao mesmo tempo)
 ordem
de
 grandeza */

//Exemplo 1: sem pa~^enteses
int resultado1 = (3 + 5) * 2; //Multiplicação tem prioridade
Console.WriteLine($"Resultado 1 (sem parênteses): (3 + 5) * 2 = {resultado1}");

int resultado2 = 3 + 5 * 2; //Multiplicação tem prioridade
Console.WriteLine($"Resultado 1 (sem parênteses):  3 + 5 * 2 = {resultado2}");

// Exemplo 2: Sem parênteses
int resultado3 = 8 / 4 + 3;  //Divisão tem prioridade
Console.WriteLine($"Resultado 3 (Sem parênteses): 8 / 4 + 3 = {resultado3}");

//Exemplo 2: Com parênteses
double resultado4 = 8.0 / (4 + 3);  //parênteses alteram ordem
Console.WriteLine($"Resultado 4 (com parênteses): 8 / (4 + 3) = {resultado4}");

