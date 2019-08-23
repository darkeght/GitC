using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadComEscolhadeQuantidade
{
    class Program
    {
        static List<ListaThread> listThreadload = new List<ListaThread>();
        static long indice1 = 0;
        static long indice2 = 0;
        static long indice3 = 0;
        static long indice4 = 0;
        static void Main(string[] args)
        {
            //inicialização de uma nova thread para incrementar o operador de inidce 1
            Thread t1 = new Thread(incrementIdex1);
            t1.Start();

            Thread t2 = new Thread(incrementIdex2);
            t2.Start();

            Thread t3 = new Thread(incrementIdex3);
            t3.Start();

            var iniciou = DateTime.Now;

            //Divisão de informações a serem processadas pelas threads 
            while ((indice1 + indice2 + indice3) < 999999999) { }

            var tempoTotal = DateTime.Now - iniciou;

            Console.WriteLine($"Tempo para execução:{tempoTotal}");
            Console.ReadKey();//00:00:03.44
        }
        public static void incrementIdex1()
        {
            while(indice1 < 333333333)
                    indice1++;
        }

        public static void incrementIdex2()
        {
            while (indice2 < 333333333)
                indice2++;
        }
        public static void incrementIdex3()
        {
            while (indice3 < 333333333)
                indice3++;
        }

        public static void incrementIdex4()
        {
            while (indice4 < 250000000)
                indice4++;
        }

        public static void CarregaLista()
        {
            for (long i = 0; i < 1000000; i++)
            {
                try
                {
                    listThreadload.Add(new ListaThread()
                    {
                        //Numero = indice++
                    });
                }
                catch
                {
                    ///EstorouIndice
                }
            }
        }
    }

    public class ListaThread
    {
        /// <summary>
        /// Número que define a ordem de criação
        /// </summary>
        public long Numero { get; set; } = 0;
        /// <summary>
        /// Identificador booleano que mostra se foi atualizado
        /// </summary>
        public bool Atualizado { get; set; } = false;
    }
}
