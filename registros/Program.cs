using System;
using System.IO;

namespace AulaRegistrosArquivos
{
    public struct cliente
    {
        public string Nome;
        public int Idade;
        public string Email;
    }

    class program
    {
        static void Main(string[] args)
        {
            //Declaração e uso básico de registros
            cliente cliente1;
            cliente1.Nome = "João";
            cliente1.Idade = 30;
            cliente1.Email = "joao@example.com";

            Console.WriteLine("=== Cliente 1 ===");
            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Idade: " + cliente1.Idade);
            Console.WriteLine("Email: " + cliente1.Email);
            Console.WriteLine();

            //Segunda Gravação e exibiçã de informações
            cliente cliente2;
            cliente1.Nome = "Maria";
            cliente1.Idade = 25;
            cliente1.Email = "maria@example.com";

            Console.WriteLine("=== Cliente 2 ===");
            Console.WriteLine("Nome: " + cliente1.Nome);
            Console.WriteLine("Idade: " + cliente1.Idade);
            Console.WriteLine("Email: " + cliente1.Email);
            Console.WriteLine();

            // Organização de dados em tabela (vetor de registros)
            cliente[] clientes = new cliente[2];
            clientes[0].Nome = "João";
            clientes[0].Idade = 30;
            clientes[0].Email = "joao@example.com";
            clientes[1].Nome = "Maria";
            clientes[1].Idade = 25;
            clientes[1].Email = "maria@example.com";

            Console.WriteLine("=== Tabela de Clientes ===");
            foreach (cliente cliente in clientes)
            {
                Console.WriteLine("Nome: " + cliente.Nome);
                Console.WriteLine("Idade: " + cliente.Idade);
                Console.WriteLine("Email: " + cliente.Email);
                Console.WriteLine();
            }

            // === Gravação de dados em arquivo ===
           cliente cliente3;
            cliente3.Nome = "Carlos";
            cliente3.Idade = 40;
            cliente3.Email = "carlos@example.com";

            string caminhoArquivo = "clientes.txt";

            using (StreamWriter sw = new StreamWriter(caminhoArquivo))
            {
                sw.WriteLine("=== Cliente 3 ===");
                sw.WriteLine("Nome: " + cliente3.Nome);
                sw.WriteLine("Idade: " + cliente3.Idade);
                sw.WriteLine("Email: " + cliente3.Email);
            }

            Console.WriteLine("=== Gravação em Arquivo ===");
            Console.WriteLine($"Informações de {cliente3.Nome} gravadas em '{caminhoArquivo}'.");
            Console.WriteLine();

            //Leitura do arquivo gravado
            Console.WriteLine("=== Conteúdo do Arquivo ===");
            string conteudo = File.ReadAllText(caminhoArquivo);
            Console.WriteLine(conteudo);

            Console.WriteLine("\n=== Fim da Execução ===");
        }
    }
}