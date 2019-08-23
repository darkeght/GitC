using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodeBeber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um nome:"); //WriteLine esquevre informação e quebra a linha depois.
            var nome = Console.ReadLine(); // ReadLine le uma linha inteira com mais de 1 informação

            Console.WriteLine("Informe a idade:");
            int.TryParse(Console.ReadLine(), out int idade);//TryParse espera uma string  e depois da virgula para separar
                                                            //o os parametros temos a saida do valor inserido.  
                                                            // colocando "out int" temos a criação da variavel
                                                            // colocando apenas "out" precisamos informar uma variavel existente.

            if(idade > 18)
            {
                Console.WriteLine($"Bora {nome} Sextou carai bora, arranca o teto da baia que vou chegar vuanduuuuuuu!!!!!!!");
            }
            else
            {
                Console.WriteLine($"{nome}, infelizmente você não esta apto a beber.");
            }

            Console.ReadKey();
        }
    }
}
