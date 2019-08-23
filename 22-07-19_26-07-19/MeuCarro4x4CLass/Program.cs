using MeuCarro4x4CLass.MyFirstClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuCarro4x4CLass
{
    class Program
    {
        static void Main(string[] args)
        {
            var teste = new Carro();

            teste++;

            teste.MostrarCarro();

            Console.ReadKey();
        }
    }
}
