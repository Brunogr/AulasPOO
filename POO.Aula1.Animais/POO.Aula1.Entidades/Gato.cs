using POO.Aula1.Entidades.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Aula1.Entidades
{
    public class Gato : Mamifero
    {
        public Gato(double peso, int idade, string nome, string corPelos, string sexo, string raca) : base(peso, idade, nome, sexo, corPelos)
        {
            this.raca = raca;
        }

        public override void FazBarulho()
        {
            Console.WriteLine($"Gato {this.Nome} faz miau");
        }

        public void Escalar()
        {
            Console.WriteLine($"Gato {this.Nome} está escalando a parede.");
        }
    }
}
