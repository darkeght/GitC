using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfValidFields.Controller;

namespace WpfValidFields
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            #region Commit 
            /* string email = txtemail.Text;
             string phone = txtphone.Text;
             //^\++[1-9]{2}\       +12 64654654
             // (\([0-9]{2}\))\s([9]{1})?([0-9]{4})-([0-9]{4})$


              var stringRegTelefone = @"^\++[0-9]{2}\ (\([0-9]{2}\))\s([9]{1})?([0-9]{4})-([0-9]{4})$";


             Regex regexPhone = new Regex(stringRegTelefone);

             var matchPhone = regexPhone.IsMatch(phone);

             if (ValidatesCustom.ValidEmail(email))
                 MessageBox.Show("E-mail Valido!");
             else
                 MessageBox.Show("E-mail invalido");


             if (matchPhone)
                 MessageBox.Show("Telefone Valido!");
             else
                 MessageBox.Show("Telefone invalido");*/

            /*var retorno = double.TryParse("dh66ujf", out double algumacoisa);

            MessageBox.Show(msgShowSeusAmores + "Resposta" + retorno);*/
            #endregion


            try
            {
                var inteiro = int.Parse("Batata");
            }
            catch(Exception erro)
            {
               /// MessageBox.Show("Deu erro meu irmão");
            }

            MessageBox.Show("Deu tudo certo.");
        }

        public bool CafeTime(out string saoTudoUnsPaozinho)
        {
            if("08/08/2019 14:52:50"
                == DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"))
            {
                saoTudoUnsPaozinho = "Bora ?";
                return true;
            }
            else
            {
                saoTudoUnsPaozinho = "Deu boa ou não ?";
                return false;
            }
        }

        public void PotatorEscandinavo()
        {
            MessageBox.Show("Sem parametros");
        }

        public void PotatorEscandinavo(bool forcado)
        {
            if (forcado)
                MessageBox.Show("Foi na marra");
            else
                MessageBox.Show("Ai que delicia");
        }

        public void PotatorEscandinavo(bool banheiro,string quemFoiNoBanheiro = "GIOMAR",int pulsaoPulgmatico = 999)
        {
            if (banheiro)
                MessageBox.Show($"O {quemFoiNoBanheiro} foi no banheiro destruidor e seu pulsão é de mais de {pulsaoPulgmatico}");
            else
                MessageBox.Show($"O {quemFoiNoBanheiro} esta de boas e seu pulsão é de mais de {pulsaoPulgmatico}.");
        }
    }
}
