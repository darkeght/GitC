using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_indexOf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o texto desejado:");
            var texto = Console.ReadLine();

            var pos = texto.ToLower().IndexOf("Felipe".ToLower());// retorna um valor int indicando a 
            //posição inicial da minha string dentro do meu texto de busca

            Console.WriteLine($"Pos: {pos}");

            var texto2 = texto.Substring(pos, 2);//Substring espera dois parametros 
            // startindex que representa a pos inicial para seleção
            // length representa o tamanho da minha seleção 


            Console.WriteLine($"Texto de busca: {texto2}");

            if(texto.Length > 50)
            {
                var texto3 = texto.Substring(texto.IndexOf("senha:") + 6, 5);
                //Substring inicia da posição 

                Console.WriteLine($"Texto de busca 2: {texto3}");
            }


            var teste = texto.Split(',');

            Console.ReadKey();

        }
    }
}
