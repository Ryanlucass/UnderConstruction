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

            public  string Decode(string code)
            {
                string[] ArrayCode = code.Split(" ");

                string result = "";
                foreach (var i in ArrayCode)
                {
                    if (_Dict.TryGetValue(i, out string value))
                    {
                        result += value;
                    }
                }
                return result;
            }

        public string Encoder(string code)
        {
            List<string> Arrayname = new List<string>();

            //for (int i = 0; i<code.Length; i++)
            //{
            //    Arrayname.Add(code.Substring(i, 1));
            //}

            var result = string.Join("", Arrayname.Select(s => _Dict.FirstOrDefault(f => f.Value == s.ToUpper()).Key));
       
            return result;
        } 
    }
}

