using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UnderConstruction
{
    public class ValidationIpv4 {
        public static void ValidationIpv4Regex(List<string> endereco)
        {
            //var result = string.Join("", endereco.Select(i=> ));

                string regex = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";

           
                var resultado = endereco.Select(x=> Regex.IsMatch(x, regex)).ToList();

               
        }
    }
}

