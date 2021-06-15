using POO.Aula1.Entidades;
using System;

namespace POO.Aula1
{
    class Program
    {
        static void Main(string[] args)
        {
            var pitbull = new Cachorro((double)45, 5, "rex", "M", "preto", "pitbull");

            var filhote = new Cachorro((double)5, 0, "bebe", "M", "branco", "poodle");

            var mae = new Cachorro((double)15.2, 3, "bela", "F", "branco", "poodle");

            var siames = new Gato((double)10.5, 2, "gatinho", "F", "cinza", "siames");

            siames.FazBarulho();
            siames.Escalar();

            pitbull.FazBarulho();

            mae.Amamentar(filhote);

            pitbull.Amamentar(filhote);

            pitbull.Cacar(siames);

            Console.ReadKey();

        }
    }
}
