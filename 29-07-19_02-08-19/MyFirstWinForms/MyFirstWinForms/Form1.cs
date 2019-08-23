using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstWinForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Variavel para contar o click do botão
        int countPress = 426;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            countPress--;
            this.button1.Size = new System.Drawing.Size(776, countPress);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hummmmmmmm");
            Random r = new Random();

            this.button2.Location = new System.Drawing.Point(r.Next(700), r.Next(400));

            this.Close();
        }
    }
}
