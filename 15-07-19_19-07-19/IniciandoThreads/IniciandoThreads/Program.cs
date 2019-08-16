using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IniciandoThreads
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classe do .net que trabalha com Threads paralelas com funções basicas de repetição
            Parallel.For(0, 3, i =>
             {
                 ImprimeOCafeEstaPronto(i);
                 ImprimeOAlmocoEstaPronto(i);
             });

            Console.ReadKey();//Espera precionar uma tecla para dar continuidade
        }
        public static void ImprimeOCafeEstaPronto(int numero)
        {
            Parallel.For(0,3, i => { Console.WriteLine($"O café Esta Prionto {numero}:{i}");  });
        }

        public static void ImprimeOAlmocoEstaPronto(int numero)
        {
            Parallel.For(0, 3, i => { Console.WriteLine($"O almoço Esta Prionto {numero}:{i}"); });
        }
    }
}
