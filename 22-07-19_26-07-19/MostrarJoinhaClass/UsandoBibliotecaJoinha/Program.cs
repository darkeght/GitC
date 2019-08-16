using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MostrarJoinhaClass;

namespace UsandoBibliotecaJoinha
{
    class Program
    {
        static void Main(string[] args)
        {
            /*new AquiMostraJoinha().MetodoInicialDoJoinha();

            new AquiMostraJoinha().MetodoDoisPontoZero(true);

            new AquiMostraJoinha().MetodoDoisPontoZero(false);*/

            //Operação pesada como leitura e gravação na memoria
            var outroCaraParaRealizarOTeste = new AquiMostraJoinha()
                .TesteUmOperadorLegal();
            //Contagem de todos os registros da nossa lista
            var tamanhoDaLista = outroCaraParaRealizarOTeste.Length;
            //Nosso for agora esta mais rapido
            for (int i = 0; i < tamanhoDaLista; i++)
            {
                Console.WriteLine(outroCaraParaRealizarOTeste[i]);
            }

            

            Console.ReadKey();
        }
    }
}
