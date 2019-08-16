using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriacaoDeLista_ComClass.BibliotecaList
{
    public class ListViewCustom
    {
        string[] lista;

        public ListViewCustom()
        {
            lista = new string[10];

            CarregaLista();
        }
        
        private void MudarTamanho(int novoTamanho)
        {
            lista = new string[novoTamanho];
        }

        public void CarregaLista()
        {
            //laço que usamos geralmente para andar sobre as posições da nossa lista
            for (int i = 0; i < lista.Length; i++)
            {
                //carregando os valores da nossa lista aqui 
                //aonde "i" representa cada espaço que temos disponivel
                lista[i] = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss.fff");
                //DateTime e um tipo do .net c# que disponibiliza funções relacionadas a datas
                //e horas, ou seja se precisar trabalhar com essas informações é possivel usar esse cara.
            }
        }

        public void MostrarLista()
        {
            //Laço de repetição que usamos para varrer nossa lista de maneira mais simples
            foreach (var item in lista)//"var item" indica uma unidade da nossa lista "in lista" 
                //indica a lista que desejamos varrer
                Console.WriteLine(item);//Aqui apresentamos essa informação na tela

            Console.ReadKey();
        }

        public void LimparLista()
        {
            for (int i = 0; i < lista.Length; i++)
                lista[i] = string.Empty;
        }

    }
}
