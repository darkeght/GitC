using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

namespace EncryptAndDescrypt
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
            if(!string.IsNullOrEmpty(tbxInformacaoParaEsconder.Text)
                && !string.IsNullOrEmpty(tbxSenhaParaPoderEsconder.Text))
            {
                tbxConteudoJaEscondido.Text = Ecrypt.Criptografar(tbxInformacaoParaEsconder.Text
                    , tbxSenhaParaPoderEsconder.Text);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(tbxInformacaoParaEsconder.Text)
                && !string.IsNullOrEmpty(tbxSenhaParaPoderEsconder.Text))
            {

                var teste =  Ecrypt.DecryptString(tbxConteudoJaEscondido.Text
                    , tbxSenhaParaPoderEsconder.Text);
                tbxConteudoJaEscondido.Text = teste;
            }
        }


        public static class Ecrypt
        {
            private const string initVector = "pemgail9uzpgzl88";
            private const int keysize = 256;

            public static string Criptografar(string pTexoEsconder,string pSenha)
            {
                byte[] iniciandiVetorBytes = Encoding.UTF8.GetBytes(initVector);
                byte[] textoPLanoBytes = Encoding.UTF8.GetBytes(pTexoEsconder);

                PasswordDeriveBytes password = new PasswordDeriveBytes(pSenha, null);
                byte[] keyBytes = password.GetBytes(keysize / 8);
                RijndaelManaged symetrycKey = new RijndaelManaged();
                symetrycKey.Mode = CipherMode.CBC;
                ICryptoTransform encrypto = symetrycKey.CreateEncryptor(keyBytes, iniciandiVetorBytes);
                MemoryStream memoryStream = new MemoryStream();
                CryptoStream cryptoStream = new CryptoStream(memoryStream, encrypto,CryptoStreamMode.Write);
                cryptoStream.Write(textoPLanoBytes, 0, textoPLanoBytes.Length);
                cryptoStream.FlushFinalBlock();

                byte[] textoEmMemoria = memoryStream.ToArray();
                memoryStream.Close();
                cryptoStream.Close();

                return Convert.ToBase64String(textoEmMemoria);
            }

            public static string DecryptString(string cipherText, string passPhrase)
            {
                byte[] initVectorBytes = Encoding.ASCII.GetBytes(initVector);
                byte[] cipherTextBytes = Convert.FromBase64String(cipherText);
                PasswordDeriveBytes password = new PasswordDeriveBytes(passPhrase, null);
                byte[] keyBytes = password.GetBytes(keysize / 8);
                RijndaelManaged symmetricKey = new RijndaelManaged();
                symmetricKey.Mode = CipherMode.CBC;
                ICryptoTransform decryptor = symmetricKey.CreateDecryptor(keyBytes, initVectorBytes);
                MemoryStream memoryStream = new MemoryStream(cipherTextBytes);
                CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read);
                byte[] plainTextBytes = new byte[cipherTextBytes.Length];
                int decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                memoryStream.Close();
                cryptoStream.Close();
                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
            }
        }
    }
}
