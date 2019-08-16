using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace Calculadora.View
{
    /// <summary>
    /// Interaction logic for ucLogin.xaml
    /// </summary>
    public partial class ucLogin : UserControl
    {
        public ucLogin()
        {
            InitializeComponent();
        }
        public event EventHandler Sucess;
        public event EventHandler Fail;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(tbxLogin.Text == "admin"
                && tbxPass.Password == "admin")
                Sucess("Logado com usuário admin do sistema", new EventArgs());
            else
                Fail($"Usuario:{tbxLogin.Text} ou senha: *******" +
                    $"{tbxPass.Password.Substring(tbxPass.Password.Length - 3, 2)} inválido.", new EventArgs());
        }
    }
}
