using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoDaCalculadora;

namespace UsandoABibliotecaDaCalculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            var bbCalc = new Calculadora();

            Console.WriteLine(bbCalc.CalculaAdicao(5,5));

            Console.ReadKey();
        }
    }
}
