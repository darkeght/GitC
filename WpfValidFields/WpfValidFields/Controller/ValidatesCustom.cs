using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace WpfValidFields.Controller
{
    public class ValidatesCustom
    {
        public static bool ValidEmail(string email)
        {
            var stringRegEmail = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            Regex regexmail = new Regex(stringRegEmail);

            return regexmail.IsMatch(email);
        }
    }
}
