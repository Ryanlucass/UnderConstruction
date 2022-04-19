using System;
using System.Collections.Generic;
using System.Linq;
using UnderConstruction.Interfaces;

namespace UnderConstruction
{
    public class MorseCode : IMorseCode
    {
        private Dictionary<string, string> _Dict { get; set; }

        public MorseCode(Dictionary<string, string> pairs)
        {
            _Dict = pairs;
        }

        public  string Decode(string code, string result)
        {
            string[] ArrayCode = code.Split(" ");

            foreach (var i in ArrayCode)
            {
                if (_Dict.TryGetValue(i, out string value))
                {
                    result += value;
                }
            }

            return result;
        }

        public string Encoder(string code, string result)
        {
            List<string> Arrayname = new List<string>();

            for (int i = 0; i<code.Length; i++)
            {
                Arrayname.Add(code.Substring(i, 1));
            }

            foreach (var i in Arrayname)
            {
                //result += _Dict.Select(x => x.Key.Where(t => i == x.Value));
                //result += _Dict.Select(x => x.KeyWhere(t => i == x.Value));
            }

            return result;
        } 
    }
}

