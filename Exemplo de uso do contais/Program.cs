using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_de_uso_do_contais
{
    class Program
    {
        static string[] listaDenome = new string[]
            {   "Ab\u00edlio Camacho",
                "Alexandra Neres",
                "Bartira Motta",
                "Blasco Cabe\u00e7a de Vaca",
                "Bruno Sales",
                "D\u00e9lia Fartaria",
                "Firmino Lins",
                "Flor Jord\u00e1n",
                "Frutuoso Gomes",
                "H\u00e9lia Pav\u00eda",
                "Jana\u00edna Corte-Real",
                "Jud\u00e1 Capucho",
                "Leopoldo Correa",
                "Miguel Coutinho",
                "Minervina Peixoto",
                "Nuno Vargas",
                "Sofia Lagoa",
                "Uriel Chagas",
                "Vivaldo Camello",
                "Zenaide Prates" };
        static void Main(string[] args)
        {
            Console.WriteLine("Expressão a ser encontrada dentro da nossa lista nervosa:");
            var expressao = Console.ReadLine();//Obtem o valor da empressão a ser comparada dentro da minha lista

            Console.WriteLine("Divisor de aguas profundas _______________________.");

            for (int i = 0; i < listaDenome.Length; i++)// laço de repetição que percorre nome por nome para fazer a comparação 
            {
                if (listaDenome[i].Contains(expressao))//parte do nosso if que testa a comparação para validar se contem a informação
                    Console.WriteLine(listaDenome[i]);
            }

            Console.WriteLine("Divisor de aguas profundas _______________________.");

            BuscaValorMesmoSendoCaixaAltaOuNao(expressao);

            Console.ReadKey();
        }

        public static void BuscaValorMesmoSendoCaixaAltaOuNao(string parametro)
        {

            for (int i = 0; i < listaDenome.Length; i++)// laço de repetição que percorre nome por nome para fazer a comparação 
            {
                if (listaDenome[i].ToLower().Contains(parametro.ToLower()))//parte do nosso if que testa a comparação para validar se contem a informação
                    Console.WriteLine(listaDenome[i]);
            }
        }
    }
}
