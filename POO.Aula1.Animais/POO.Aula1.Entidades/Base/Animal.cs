using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Aula1.Entidades.Base
{
    public class Animal
    {
        public string Nome { get; protected set; }
        private double peso;
        protected string raca;
        public int Idade { get; protected set; }
        protected readonly string sexo;

        public Animal(double peso, int idade, string nome, string sexo)
        {
            this.peso = peso;
            this.Idade = idade;
            this.Nome = nome;
            this.sexo = sexo;
        }

        public virtual void FazBarulho()
        {
            Console.WriteLine("graur");
        }

        public void Anda()
        {
            Console.WriteLine("estou andando");
        }

    }
}
