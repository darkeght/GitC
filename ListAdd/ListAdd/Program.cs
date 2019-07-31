using ListAdd.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListAdd
{
    class Program
    {
        static void Main(string[] args)
        {
            //Iniciei minha lista aqui
            List<Lanche> listaAdd = new List<Lanche>();

            for (int i = 0; i < 2; i++)
            {
                listaAdd.Add(new Lanche() {
                    Nome = RetornaValores("Nome"),
                    Quantidade = int.Parse(RetornaValores("Quantidade")),
                    Valor = double.Parse(RetornaValores("Valor"))
                });
            }

            foreach (Lanche item in listaAdd)
                Console.WriteLine($"Nome:{item.Nome} Quant:{item.Quantidade} Val:{item.Valor}");

            Console.ReadKey();
        }
        /// <summary>
        /// Metodo que mostra uma interface legal para adicionar os valores
        /// </summary>
        /// <param name="nome">Nome do campo que ira retornar o valor</param>
        /// <returns>Retorna uma string com o valor</returns>
        public static string RetornaValores(string nome)
        {//informo e retorno o valor conforme a solicitação do campo
            Console.WriteLine($"Informe o valor para o campo:{nome}");
            return Console.ReadLine();
        }
    }
}
