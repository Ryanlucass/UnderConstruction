using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using UnderConstruction.Interfaces;

namespace UnderConstruction
{
    public class UtiliRegex : IConector
    {

        public string Text {
            get { return "\n02 - Validação de Ipv4\n"; }
            set { }
        }
        public string UrlKata { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public static string ValidationIpv4Regex(string endereco)
        {
            string regex = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";
         
            return Regex.IsMatch(endereco, regex) == false ? "Inválido" : "Válido";
 
        }
        public string ValidationPangram(string text) => text.ToLower().Where(ch => Char.IsLetter(ch)).GroupBy(ch => ch).Count() == 26 == false ? "Não é Pangram" : "É Pangram";
    }
}

