using System;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            c.Marca = "GM";
            c.Modelo = "Astra";
            c.Mover();
            Console.ReadLine();

            Aviao a = new Aviao();
            a.Modelo = "F22";
            a.Mover();

            Console.ReadLine();
        }
    }
}
