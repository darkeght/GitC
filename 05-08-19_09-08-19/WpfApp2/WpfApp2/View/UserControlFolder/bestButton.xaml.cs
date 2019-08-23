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

namespace WpfApp2.View.UserControlFolder
{
    /// <summary>
    /// Interaction logic for bestButton.xaml
    /// </summary>
    public partial class bestButton : UserControl
    {
        public bestButton()
        {
            InitializeComponent();
        }

        public string TextShow { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
