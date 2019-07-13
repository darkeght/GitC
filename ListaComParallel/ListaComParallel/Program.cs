using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaComParallel
{
    class Program
    {
        static List<ParallelListTeste> listaDeitens = new List<ParallelListTeste>();
        static void Main(string[] args)
        {
            var iniciDaoperacao = DateTime.Now;
            CarregaLista();
            var tempoTotal = DateTime.Now - iniciDaoperacao;

            Console.WriteLine($"Tempo total para executar a operação: {tempoTotal}");
            Console.ReadKey();
        }

        public static void CarregaListaParallel()
        {
            Parallel.For(0,62000, i =>
            {
                listaDeitens.Add(new ParallelListTeste()
                {
                    Numero = i
                });
            });
        }

        public static void CarregaLista()
        {
            for (int i = 0; i < 62000; i++)
            {
                listaDeitens.Add(new ParallelListTeste()
                {
                    Numero = i
                });
            }
        }
    }

    public class ParallelListTeste
    {
        /// <summary>
        /// Número que indica a ordem de criação deste item;
        /// </summary>
        public long Numero { get; set; } = 0;
        /// <summary>
        /// Indicador booleano que mostra se foi atualizado ou não.
        /// </summary>
        public bool Atualizado { get; set; } = false;
    }
}
