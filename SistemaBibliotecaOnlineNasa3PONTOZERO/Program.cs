using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
////
namespace SistemaBibliotecaOnlineNasa3PONTOZERO
{
    class Program
    {
        static string[,] baseDeLivros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            MostrarSejaBemVindo();

            if(MenuInicial() == 1)
            {
                Console.Clear();

                MostrarSejaBemVindo();

                Console.WriteLine("Menu - Alocação de livros");
                Console.WriteLine("Digite o nome do livro a ser alocado:");

                var nomedolivro = Console.ReadLine();
                if(PesquisaLivroParaAlocacao(nomedolivro))
                {
                    Console.Clear();
                    Console.WriteLine("Você deseja alocar o livro? para sim(1) para não(0)");
                   
                    if (Console.ReadKey().KeyChar.ToString() == "1")
                    {
                        AlocarLivro(nomedolivro);
                        Console.Clear();
                        Console.WriteLine("Livro Alocado com sucesso!");
                    }
                    else
                        Console.Clear();
                    
                    Console.WriteLine("Listagem de livros:");

                    for (int i = 0; i < baseDeLivros.GetLength(0); i++)
                    {
                        Console.WriteLine($"Nome: {baseDeLivros[i,0]} Disponivel:{baseDeLivros[i,1]}");
                    }
                }
            }

            Console.ReadKey();
        }
        /// <summary>
        /// Mostra as informações iniciais do sistema.
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("________________________________________________");
            Console.WriteLine("         Sistema de alocação de livros.");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("    Desenvolvido pelas industrias EneEseAaaaa");
            Console.WriteLine("________________________________________________");
        }
        /// <summary>
        /// Metodo que mostra o menu inicial com as opções para escolha.
        /// </summary>
        /// <returns>Retorna o número do menu escolhido.</returns>
        public static int MenuInicial()
        {
            Console.WriteLine("\r\nMenu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um livro.");
            Console.WriteLine("2 - Sair do sistema.");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Metodo que carrega a base de dados dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeLivros = new string[2, 2]
            {
                {"O pequeno","sim"},
                {"O grande","não"}
            };
        }
        /// <summary>
        /// Metodo que retorna se um livro pode ser alocado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser pesquisado</param>
        /// <returns>Retorna verdadeiro em caso o livro estiver livre para alocação.</returns>
        public static bool PesquisaLivroParaAlocacao(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                {
                    Console.WriteLine($"O livro:{nomeLivro}" +
                          $" pode ser alocado?:{baseDeLivros[i, 1]}");

                    return baseDeLivros[i, 1] == "sim";
                }
            }

            return false;
        }
        /// <summary>
        /// Metodo que aloca o livro de acordo com o parametro passado.
        /// </summary>
        /// <param name="nomeLivro">Nome do livro a ser alocado.</param>
        public static void AlocarLivro(string nomeLivro)
        {
            for (int i = 0; i < baseDeLivros.GetLength(0); i++)
            {
                if (nomeLivro == baseDeLivros[i, 0])
                    baseDeLivros[i, 1] = "não";
            }
        }
    }
}
