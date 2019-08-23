using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEscola.Classes
{
   public class Boletim
    {
      public int medias(int nota1, int nota2, int nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }

      public int frequencia(int totalAulas, int numeroFaltas)
        {
            return ((totalAulas - numeroFaltas) * 100) / totalAulas;
        }

      public void situacao(int media, int frequencia)
        {
          if ((media >= 7) && (frequencia >=75))
            {
                Console.WriteLine($"Aluno aprovado com média {media} e frequencia de {frequencia}%");
            }
          else
            {
                Console.WriteLine($"Aluno reprovado com média {media} e frequencia de {frequencia}%");
            }
        }

        public string RetornaSituacao(int media, int frequencia)
        {
            if ((media >= 7) && (frequencia >= 75))
            {
                return "Aprovado";
            }
            return "Reprovado";
        }

    }
}
