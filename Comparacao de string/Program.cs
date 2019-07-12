using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comparacao_de_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe um valor inicial");
            var primeiroValor = Console.ReadLine();//Obtem todos os valores digitados antes de ser precionado enter 
                                                   //dentro de um a linha, esta variavel representa o primeiro valor digitado.
                                                   //ReadLine sempre retorna uma string
                                                   // Como ele e um metodo ele precisa dos indicadores "()"
            Console.WriteLine("informe um valor para comparação");
            var segundoValor = Console.ReadLine();//Realiza o mesmo como descrito nas linhas superiores mas 
                                                  //agora ele pega o segundo valo, o quela usaremos para comparar


            if (primeiroValor == segundoValor)//Comparação exata de valores os mesmo não podem ter nenhuma diferença 
                Console.WriteLine("O primeiro valor é exatamente igual ao segundo valor.");
            else
                Console.WriteLine("Os valores não são exatamente iguais.");



            if (segundoValor.Contains(primeiroValor))//Verificação se o mesmo contem uma informação dentro da outra 
                Console.WriteLine("O primeiro valor contem em algum local o segundo valor.");
            else
                Console.WriteLine("Não existe nenhum valor dentro do texto informado.");
            //Ou seja ana existe dentro de "Ban'ana'"



            if (segundoValor.IndexOf(primeiroValor) > -1)//Realiza uma busca dentro da string e retorna a primeira posição
                Console.WriteLine($"O primeiro existe dentro do segundo valor pos:{segundoValor.IndexOf(primeiroValor)}");
            else
                Console.WriteLine($"infelixmente ele não retornou nada, pos:{segundoValor.IndexOf(primeiroValor)}");


            Console.ReadKey();

        }
    }
}
