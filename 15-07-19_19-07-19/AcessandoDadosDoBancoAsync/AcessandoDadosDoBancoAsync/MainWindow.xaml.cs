using AcessandoDadosDoBancoAsync.Data;
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

namespace AcessandoDadosDoBancoAsync
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

        UserContexDB context = new UserContexDB();

        List<User> usuarios = new List<User>();

        DateTime time = new DateTime();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Task.Run(() => {
                while (true)
                    time = DateTime.Now;
            });
        }

        public async void CallTeacher()
        {
            usuarios = await Task.Run(() => (from s in context.Users
                                                        where s.Id > 0
                                                        select s).ToList<User>());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*foreach (var item in usuarios)
                MessageBox.Show(item.Usuario);*/

            MessageBox.Show(time.ToString("hh:mm:ss.fff"));
        }
    }
}
