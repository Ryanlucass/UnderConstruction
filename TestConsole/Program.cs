using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace TestConsole
{
    internal class Morse
    {
        static void Main(string[] args)
        {
            //aprendendo mais sobre espressoes regulares
            //verificando números de telefone 

            string padrao = "[0-9]{4,7}-?{0,1}[0-9]{4}";
            string padrao_cpf = "[0-9]{3}.[0-9]{3}.[0-9]{3}-[0-9]{2}";

            //string textoDeTeste = "akjsdhkasjdhsa 8599661-4167";
            string cpfoDeTeste = "akjsdhkasjdhsa 8599661-4167 617.113.693-06 61.71.13.69.30.6";

            var resultado = Regex.Match(cpfoDeTeste, padrao_cpf);

            //Console.WriteLine(resultado.Value);

            Console.WriteLine(resultado.Value);

        }
    }
}
