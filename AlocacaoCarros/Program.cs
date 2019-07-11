using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlocacaoCarros
{
    class Program
    {
        static string[,] baseDeCarros;
        static void Main(string[] args)
        {
            CarregaBaseDeDados();

            var opcaoMenu = MenuPrincipal();

            while (opcaoMenu != 4)
            {
                if (opcaoMenu == 1)
                    AlocarUmCarro();

                if (opcaoMenu == 2)
                    DesalocarUmCarro();

                if (opcaoMenu == 3)
                {
                    MostrarListaDeCarros();
                    Console.Read();
                }

                opcaoMenu = MenuPrincipal();
            }

            Console.ReadKey();
        }

        /// <summary>
        /// Mostra as informações iniciais do sistema.
        /// </summary>
        public static void MostrarSejaBemVindo()
        {
            Console.WriteLine("________________________________________________");
            Console.WriteLine("         Sistema de alocação de Carros.");
            Console.WriteLine("________________________________________________");
            Console.WriteLine("    Desenvolvido pelas industrias EneEseAaaaa");
            Console.WriteLine("________________________________________________");
        }
        /// <summary>
        /// Metodo que mostra o menu inicial com as opções para escolha.
        /// </summary>
        /// <returns>Retorna o número do menu escolhido.</returns>
        public static int MenuPrincipal()
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine("Menu - Inicial");
            Console.WriteLine("O que você deseja realizar?");
            Console.WriteLine("1 - Alocar um Carro.");
            Console.WriteLine("2 - Devolver um Carro.");
            Console.WriteLine("3 - Listar Carros.");
            Console.WriteLine("4 - Sair do sistema.");
            Console.WriteLine("Digite o número desejado:");

            int.TryParse(Console.ReadKey().KeyChar.ToString(), out int opcao);

            return opcao;
        }
        /// <summary>
        /// Metodo que carrega a base de dados dentro do sistema.
        /// </summary>
        public static void CarregaBaseDeDados()
        {
            baseDeCarros = new string[2, 3]
            {
                {"vectra","2010","sim"},
                {"sportage","2010","não"}
            };
        }
        /// <summary>
        /// Metodo que retorna se um Carro pode ser alocado.
        /// </summary>
        /// <param name="nomeCarro">Nome do Carro a ser pesquisado</param>
        /// <returns>Retorna verdadeiro em caso o Carro estiver livre para alocação.</returns>
        public static bool PesquisaCarroParaAlocacao(string nomeCarro)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                if (nomeCarro == baseDeCarros[i, 0])
                {
                    Console.WriteLine($"O Carro:{nomeCarro}" +
                          $" pode ser alocado?:{baseDeCarros[i, 2]}");

                    return baseDeCarros[i, 2] == "sim";
                }
            }

            return false;
        }
        /// <summary> 
        /// Metodo para alterar a informação de alocação do Carro.
        /// </summary>
        /// <param name="nomeCarro">Nome do Carro</param>
        /// <param name="alocar">Valor booleano que define se o Carro esta ou não disponivel.</param>
        public static void AtualizarCarro(string nomeCarro, bool alocar)
        {
            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                if (nomeCarro == baseDeCarros[i, 0])
                {
                    baseDeCarros[i, 2] = alocar ? "não" : "sim";
                }
            }

            Console.Clear();
            MostrarSejaBemVindo();
            Console.WriteLine("Carro atualizado com sucesso!");
        }
        /// <summary>
        /// Metodo que carrega o conteudo inicial da aplicação do menu 1
        /// </summary>
        public static void AlocarUmCarro()
        {
            MostrarMenuInicialCarros("Alocar um Carro:");

            var nomedoCarro = Console.ReadLine();
            if (PesquisaCarroParaAlocacao(nomedoCarro))
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja alocar o Carro? para sim(1) para não(0)");

                AtualizarCarro(nomedoCarro, Console.ReadKey().KeyChar.ToString() == "1");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
        }
        /// <summary>
        /// Metodo que mostra a lista de Carros atualizado
        /// </summary>
        public static void MostrarListaDeCarros()
        {
            Console.WriteLine("Listagem de Carros:");

            for (int i = 0; i < baseDeCarros.GetLength(0); i++)
            {
                Console.WriteLine($"Nome: {baseDeCarros[i, 0]} Disponivel:{baseDeCarros[i, 2]}");
            }
        }
        public static void DesalocarUmCarro()
        {
            MostrarMenuInicialCarros("Desalocar um Carro:");

            MostrarListaDeCarros();

            var nomedoCarro = Console.ReadLine();
            if (!PesquisaCarroParaAlocacao(nomedoCarro))
            {
                Console.Clear();
                MostrarSejaBemVindo();
                Console.WriteLine("Você deseja desalocar o Carro? para sim(1) para não(0)");

                AtualizarCarro(nomedoCarro, Console.ReadKey().KeyChar.ToString() == "0");

                MostrarListaDeCarros();

                Console.ReadKey();
            }
        }
        public static void MostrarMenuInicialCarros(string operacao)
        {
            Console.Clear();

            MostrarSejaBemVindo();

            Console.WriteLine($"Menu - {operacao}");
            Console.WriteLine("Digite o nome do Carro para realizar a operação:");
        }


    }
}
