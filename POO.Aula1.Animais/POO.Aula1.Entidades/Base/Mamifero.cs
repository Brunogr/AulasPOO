using System;
using System.Collections.Generic;
using System.Text;

namespace POO.Aula1.Entidades.Base
{
    public class Mamifero : Animal
    {
        private string corPelos;

        public Mamifero(double peso, int idade, string nome, string sexo, string corPelos) : base(peso, idade, nome, sexo)
        {
            this.corPelos = corPelos;
        }

        public void Amamentar(Mamifero mamifero)
        {
            if (this.sexo == "F" && mamifero.Idade > 1)
                Console.WriteLine($"Mamifero {this.Nome} está amamentando o mamifero {mamifero.Nome}");
            else
                Console.WriteLine("Mamífero do sexo masculino não amamenta.");
        }
    }
}
