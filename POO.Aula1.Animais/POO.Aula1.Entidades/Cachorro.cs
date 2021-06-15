using System;
using System.Collections.Generic;
using System.Text;
using POO.Aula1.Entidades.Base;

namespace POO.Aula1.Entidades
{
    public class Cachorro : Mamifero
    {
        public Cachorro(double peso, int idade, string nome, string sexo, string corPelos, string raca) : base(peso, idade, nome, sexo, corPelos)
        {
            this.raca = raca;
        }

        public override void FazBarulho()
        {
            Console.WriteLine($"Cachorro {this.Nome} diz Auau");
        }

        public void Cacar(Mamifero mamifero)
        {
            Console.WriteLine($"Caçando mamífero {mamifero.Nome}.");
        }
    }
}
