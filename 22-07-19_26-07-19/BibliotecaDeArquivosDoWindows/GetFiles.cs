using System;
using System.IO;

namespace BibliotecaDeArquivosDoWindows
{
    public class GetFiles
    {
        /// <summary>
        /// Metodo que retorna os arquivos do diretorio dos meu documentos padrão do windows
        /// </summary>
        /// <returns></returns>
        public string[] RetornaArquivosDoMeuDocumentos()
        {
            var files = Directory.GetFiles(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments));

            return files;
        }
        /// <summary>
        /// Metodo que busca dentro da pasta de imagens os arquivos que a mesma contem
        /// </summary>
        /// <returns>Retorna a lista de arquivos dentro da pasta</returns>
        public string[] RetornaArquivosImagesFiles()
        {
            var files = Directory.GetFiles(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.MyPictures));

            return files;
        }
        /// <summary>
        /// Metodo que verifica se existe a pasta de arquivos do git dentro do diretorio
        /// fixo "C:\GIT\GitC"
        /// </summary>
        /// <returns>Retorna quando exisitr a listagem de arquivos dentros deste diretorio</returns>
        public string[] RetornaArquivosGit()
        {
            if(!Directory.Exists(@"C:\GIT\GitC"))
                return null;

            var files = Directory.GetFiles(@"C:\GIT\GitC");

            return files;
        }
    }
}
