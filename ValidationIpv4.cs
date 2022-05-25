using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace UnderConstruction
{
    public class ValidationIpv4 {
        public static void  ValidationIpv4Regex(List<string> endereco)
        {
            List<string> teste = new List<string>();
            //var result = string.Join("", endereco.Select(i=> ));
            foreach(var i in endereco)
            {                
                var result = Regex.Match(i, "[1-2][1-5][1-5][.]{2}[1-2][1-5][1-5]");
 
                Console.WriteLine($"{i} = {result.Success}");
            }

                //var result = string.Join("", Arrayname.Select(s => _Dict.FirstOrDefault(f => f.Value == s.ToUpper()).Key));
        }
    }
}

