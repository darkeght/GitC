using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEscola.Classes
{
    public class Cadastro
    {
        string[,] arrayAluno = new string[5, 5];
        Boletim boletim = new Boletim();

        public void inserir()
        {
            //for (int i = 0; i < arrayAluno.GetLength(0); i++)
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Informe o nome do aluno");
                var nome = Console.ReadLine();
                arrayAluno[i, 0] = i.ToString();

                arrayAluno[i, 1] = nome;
                //medias    
                var media = digitaNotas();
                arrayAluno[i, 2] = media.ToString();

                //informações e frequencia
                Console.WriteLine("Informe o numero de aulas");
                int.TryParse(Console.ReadLine(), out int totalAulas);               

                Console.WriteLine("Informe o numero de faltas");
                int.TryParse(Console.ReadLine(), out int numeroFaltas);
                var frequencia = boletim.frequencia(totalAulas, numeroFaltas);
                arrayAluno[i, 3] = frequencia.ToString();
                //informa situação                
                arrayAluno[i, 4] = boletim.RetornaSituacao(media, frequencia);

            }          
        }

        public int digitaNotas()
        {
            Console.WriteLine("Informe a nota 1");
            int.TryParse(Console.ReadLine(), out int nota1);

            Console.WriteLine("Informe a nota 2");
            int.TryParse(Console.ReadLine(), out int nota2);

            Console.WriteLine("Informe a nota 3");
            int.TryParse(Console.ReadLine(), out int nota3);

            //calculando a media
            return boletim.medias(nota1, nota2, nota3);
        }
        public void listar()
        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                Console.WriteLine($"Id..........: {arrayAluno[i,0]}");
                Console.WriteLine($"Nome........: {arrayAluno[i, 1]}");
                Console.WriteLine($"Média.......: {arrayAluno[i, 2]}");
                Console.WriteLine($"Frequência..: {arrayAluno[i, 3]}%");
                Console.WriteLine($"Situação....: {arrayAluno[i, 4]}\n");
            }  
        }

        public void alterar(int pId)
        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 0] == pId.ToString())
                {
                    var media = digitaNotas();
                    arrayAluno[i, 2] = media.ToString(); //media
                    var frequencia = Convert.ToInt32(arrayAluno[i, 3]);
                    arrayAluno[i, 4] = boletim.RetornaSituacao(media, frequencia);//situação
                    break;
                }
            }
        }

        public void excluir(int pId)
        {
            for (int i = 0; i < arrayAluno.GetLength(0); i++)
            {
                if (arrayAluno[i, 0] == pId.ToString())
                {
                    arrayAluno[i, 1] = "";
                    arrayAluno[i, 2] = "";
                    arrayAluno[i, 3] = "";
                    arrayAluno[i, 4] = "";
                    break;
                }
            }
        }
    }
}
