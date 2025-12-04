using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica14
{
    //Classe base (superclasse)
    internal class Animal
    {
        //Propriedade da classe Animal
        public string Nome { get; set; }

        //Método que será sobrecarregado nas classes derivadas
        public virtual void Emitirsom()
        {
            Console.WriteLine($"O animal {Nome} emite um som.");
        }
    }

    //Classe derivada (subclasse)
    internal class Cachorro : Animal
    {
        //Sobrscrevendo o método Emitirsom
        public override void Emitirsom()
        {
            Console.WriteLine($"{Nome} late: Au Au!");
        }
    }

    //Outra classe derivada
    internal class Gato : Animal
    {
        //Sobrescrevendo o método EmitirSom
        public override void Emitirsom()
        {
            Console.WriteLine($"{Nome} mia: Miaauu!");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Criando instâncias das classes derivadas
            Animal meuCachorro = new Cachorro { Nome = "Rex" };
            Animal meuGato = new Gato { Nome = "Felix" };
            Animal meuCoelho = new Animal { Nome = "Lulu" };

            //Chamando o método EmitirSom para cada animal
            meuCachorro.Emitirsom();   //Sainda: Rex late: Au Au!
            meuGato.Emitirsom();      //Saida: Felix mia: miaauu!
            meuCoelho.Emitirsom(); // o animal emite um som

            //Ultilizando Polimorfismo: Array de animais
            Animal[] animais = {meuCachorro, meuGato, meuCoelho };

            foreach (var animal in animais)
            {
                animal.Emitirsom(); // cada objeto chama o método adequado de sua classe
            }
        }
    }
}