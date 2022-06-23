using System.Collections.Generic;
using System.Linq;
using UnderConstruction.Interfaces;

namespace UnderConstruction
{
    public partial class MorseCode : IConector
    {
        public string Text
        {
            get
            {
                return "\n\n01 - Traduzir código Morse";
            }
            set { }
        }
        public string UrlKata { get  => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        
        private Dictionary<string, string> _Dict { get; set; }

        public MorseCode(Dictionary<string, string> pairs)
        {
            _Dict = pairs;
        }
        public MorseCode()
        {

        }
        /// <summary>
        /// Traduz o código morse
        /// </summary>
        /// <param name="code">código morse completo</param>
        /// <returns></returns>
        public string Decode(string code) => string.Join("", code.Split(" ").Select(x => _Dict.GetValueOrDefault(x)).ToList());

        /// <summary>
        /// Codificado o código morse
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public string Encoder(string code)
        {
            List<string> Arrayname = new();

            for (int i = 0; i < code.Length; i++)
            {
                Arrayname.Add(code.Substring(i, 1));
            }  
            
            var result = string.Join("", Arrayname.Select(s => _Dict.FirstOrDefault(f => f.Value == s.ToUpper()).Key));

            return result;
        }
    }
}

