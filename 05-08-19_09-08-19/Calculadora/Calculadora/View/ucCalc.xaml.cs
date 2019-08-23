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
    /// Interaction logic for ucCalc.xaml
    /// </summary>
    public partial class ucCalc : UserControl
    {
        public ucCalc()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var comandParameter = ((System.Windows.Controls.Primitives.ButtonBase)e.Source).CommandParameter;
            var contentValue = tbkVisor.Text;

            if (comandParameter.ToString() == "="
                && tbkVisor.Text.Contains("="))
                comandParameter = "C";

            if (comandParameter.ToString() == "=")
            {
                //organizamos os operadores para multiplicação ser sempre o primeiro
                var operatorList = ReturnOperators(contentValue.Split('=')[0])
                    .OrderBy(X => X)
                    .ToList<char>();
                //calculamos todos os operadores
                foreach (char item in operatorList)
                {
                     ReturnResult(
                        item,
                        contentValue.Split(item),
                        ref contentValue);
                }

                comandParameter = "=" + contentValue;
            }
            //identificamos que é para limpar o conteudo da nossa calculadora
            if (comandParameter.ToString() == "C")
                tbkVisor.Text = "";
            else
                tbkVisor.Text += comandParameter;
        }
        /// <summary>
        /// Metodo que realiza os calculos para nossa calculadora
        /// </summary>
        /// <param name="valueOperator">operador a ser calculado</param>
        /// <param name="valueToCalc">valores para o calculo</param>
        /// <param name="contentValues">retorna calculado a empressão especificada no operador</param>
        public void ReturnResult(char valueOperator,string[] valueToCalc,ref string contentValues)
        {
            switch (valueOperator)
            {
                case '*':
                    #region Multiplication
                    {

                        var firstValue = ReturnStringNumber(valueToCalc[0]);
                        var secondValue = ReturnStringNumber(valueToCalc[1],true);

                        var returl = (int.Parse(firstValue) * int.Parse(secondValue));

                        contentValues = contentValues.Replace($"{firstValue}*{secondValue}", $"{returl}");

                    } break;
                    #endregion
                case '+':
                    #region Addiction
                    {
                        var firstValue = ReturnStringNumber(valueToCalc[0]);
                        var secondValue = ReturnStringNumber(valueToCalc[1], true);

                        var returl = (int.Parse(firstValue) + int.Parse(secondValue));

                        contentValues = contentValues.Replace($"{firstValue}+{secondValue}", $"{returl}");
                    }
                    break;
                    #endregion
                case '/':
                    #region Division
                    {
                        var firstValue = ReturnStringNumber(valueToCalc[0]);
                        var secondValue = ReturnStringNumber(valueToCalc[1], true);

                        if (int.Parse(firstValue) > int.Parse(secondValue))
                        {
                            var returl = (int.Parse(firstValue) / int.Parse(secondValue));

                            contentValues = contentValues.Replace($"{firstValue}/{secondValue}", $"{returl}");
                        }
                        else
                        {
                            var returl = (int.Parse(secondValue) / int.Parse(firstValue));

                            contentValues = contentValues.Replace($"{firstValue}/{secondValue}", $"{returl}");
                        }
                    }
                    break;
                    #endregion
                case '-':
                    #region Subtract
                    {
                        var firstValue = ReturnStringNumber(valueToCalc[0]);
                        var secondValue = ReturnStringNumber(valueToCalc[1], true);

                        var returl = (int.Parse(firstValue) - int.Parse(secondValue));

                        contentValues = contentValues.Replace($"{firstValue}-{secondValue}", $"{returl}");
                    }
                    break;
                    #endregion
            }
        }
        /// <summary>
        /// Metodo que retorna o valor a ser calculado de acordo com a expressão
        /// </summary>
        /// <param name="stringToNumber">parte separada da string para analisar </param>
        /// <param name="Invers">variavel que le as informações da esquerda para direira ou inverso</param>
        /// <returns>retorna o valor para os calculos</returns>
        private string ReturnStringNumber(string stringToNumber,bool Invers = false)
        {
            var  retorno = string.Empty;

            if (!Invers)
            {
                for (int i = stringToNumber.Length; i > 0; i--)
                {
                    if (char.IsNumber(stringToNumber[i-1]))
                        retorno += stringToNumber[i-1].ToString();
                    else
                        break;
                }

                var listChar =  retorno.OrderByDescending(x => x).ToList<char>();

                retorno = string.Empty;

                foreach (var item in listChar)
                    retorno += item.ToString();
            }
            else
            {
                for (int i = 0; i < stringToNumber.Length; i++)
                {
                    if (char.IsNumber(stringToNumber[i]))
                        retorno += stringToNumber[i].ToString();
                    else
                        break;
                }
            }

            return retorno;
        }
        /// <summary>
        /// Metodo com expressão lambda que retorna apenas os operadores
        /// </summary>
        /// <param name="value">string que contem os operadores</param>
        /// <returns>retorna uma lista de operadores</returns>
        public List<char> ReturnOperators(string value)
        {
            return value.Where(x => !char.IsNumber(x)).ToList<char>();
        }
    }
}
