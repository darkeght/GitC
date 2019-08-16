using MinhaPrimeiraListaTipada.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinhaPrimeiraListaTipada
{
    class Program
    {
        static void Main(string[] args)
        {
            //O indicador <T> o tipo da minha lista com isso temos uma
            //lista de lanches
            List<Lanche> minhaLista = new List<Lanche>();
            //Adiciono na minha lista um pão de queijo 
            minhaLista.Add(new Lanche() {
                Nome = "Pão de queijo",
                Quantidade = 9,
                Valor = 1.85
            });

            minhaLista.Add(new Lanche()
            {
                Nome = "Bolinho de Soya + Refri Bonus: Gastrite",
                Quantidade = 3,
                Valor = 7.50
            });
            //Aqui ando pela minha lista para poder apresentar em tela os valores
            //item in significa que ele já e um indice da minha lista bonitinho
            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponiveis: {item.Nome}");

            Console.WriteLine("Removendo item");

            foreach (Lanche item in minhaLista)
            {
                if (item.Quantidade == 3)
                {
                    minhaLista.Remove(item);
                    break;
                }
            }

            foreach (Lanche item in minhaLista)
                Console.WriteLine($"Lanches disponiveis: {item.Nome}");

            Console.ReadKey();
        }
    }
}
