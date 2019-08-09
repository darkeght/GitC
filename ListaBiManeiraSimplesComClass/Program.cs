using ListaBiManeiraSimplesComClass.Carrega;
using ListaBiManeiraSimplesComClass.Mostrar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaBiManeiraSimplesComClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aqui iniciamos nosso objeto em memoria
            var Nicholas = new CarregarLista();
            //aqui chamamos o nosso metodo para carregar a lista
            Nicholas.CarregaInformacoesEListaElasEmTela();
            //carregamos novamente mas agora a classe mostrar lista 
            //aonde colocamos todas os metodos que serão direcionados para mostrar
            //a listagem de informaçoes na tela do console
            var FelipeBlindao = new MostrarLista();
            //aqui chamamos o metodo novamente
            FelipeBlindao.PesquisandoInformacoesNaNossaLista(Nicholas.ListaNome, "0");

            Console.ReadKey();
        }
    }
}
