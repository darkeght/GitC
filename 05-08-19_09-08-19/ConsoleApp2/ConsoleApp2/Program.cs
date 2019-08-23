using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append(" Amo");
            stringBuilder.Append(" Batata");
            stringBuilder.Append(" Fritaaaaaaaaa");

            Console.WriteLine(stringBuilder.ToString());

            var textToTest = "aqui vai um texto com <b algumacoisa=\"aqui tem mais coisa\">algumas</b> caracteristicas html <b>Hummmm</b>" +
                "aqui vai mais alguma coisa <b>dfhdfgh</t>";
            var regularExpression = @"<b(.*?)>(.*?)</b>";

            var result = Regex.Matches(textToTest, regularExpression);

            /*if (result)
            {
               // em caso resultado ser positivo.
            }*/

            Console.ReadKey();

        }
    }
}
