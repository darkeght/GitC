using SistemaCantinaGG.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCantinaGG
{
    class Program
    {
        static void Main(string[] args)
        {
            MaeTrocinio lanchinhoMaroto = new MaeTrocinio(20);

            while (lanchinhoMaroto.Saldo > 0.00)
            {
                MostrarMenu();

                var valor = 0.00;

                switch (Console.ReadLine())
                {
                    case "1": { valor = 3.87; } break;
                    case "2": { valor = 7.42; } break;
                    case "3": { valor = 3.19; } break;
                    case "4": { valor = lanchinhoMaroto.Saldo; } break;
                }

                if (lanchinhoMaroto.PoderDeComprarLanches(valor))
                    Console.WriteLine("Sua mana e destruidora, você comprou o lanchinho lendario.");
                else
                    Console.WriteLine("Volte para casa guerreiro seu poder chegou ao fim" +
                        "so te resta doar sua mana para fugir o dragão esta proximo.");

                Console.WriteLine($"Seus pontos de mana {lanchinhoMaroto.Saldo}/20");
                Console.ReadKey();
            }

            Console.WriteLine("Sua mana já era");
            Console.ReadKey();

        }

        public static void MostrarMenu()
        {
            Console.Clear();
            Console.WriteLine("Lanches disponiveis" +
                "\r\n 1 - Pastel de soya R$ 3,87" +
                "\r\n 2 - Bolinho de banha de porco R$ 7,42" +
                "\r\n 3 - Coxinha de gordura vegetal R$ 3,19" +
                "\r\n 4 - Doar sua mana restante para a caridade" +
                "\r\n Escolha uma opção listada:");
        }
    }
}
