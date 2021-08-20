using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo
{
    class Aviao: MeioTransporte
    {
        public string Modelo;
        public override void Mover()
        {
            Console.WriteLine($"{Modelo} voando ...");
        }
    }
}
