using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderConstruction.Interfaces
{
    public interface IMorseCode
    {
        public string Text { get; set; }
        public string Decode(string code);

        public string Encoder(string code);
    }
}
