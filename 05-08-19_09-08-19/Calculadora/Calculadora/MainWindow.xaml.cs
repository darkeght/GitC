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

namespace Calculadora
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

        private void UcLoginfrm_sucess(object sender, EventArgs e)
        {
            //Aqui apenas recebo uma informação no evento que logou.
            MessageBox.Show(sender.ToString());
            ucLoginfrm.Visibility = Visibility.Hidden;
            ucCalc.Visibility = Visibility.Visible;
        }

        private void UcLoginfrm_Fail(object sender, EventArgs e)
        {
            //Aqui apenas recebo uma informação no evento que falhou o login.
            MessageBox.Show(sender.ToString());
        }
    }
}
