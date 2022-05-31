using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderConstruction.Mock
{
    public static class MorseCodeTest
    {
        public static Dictionary<string, string> Morp
        {
            get { return new Dictionary<string, string>()
            {
                {".-","A"},
                {"-...", "B"},
                {"-.-.", "C"},
                {"-..", "D" },
                {".", "E" },
                { "..-.", "F"},
                {"--.", "G" },
                {"....", "H" },
                { "..", "I"},
                {".---", "J" },
                { "-.-", "K"},
                { ".-..", "L"},
                {"--", "M" },
                { "-.", "N"},
                { "---", "O"},
                { ".--.", "P"},
                { "--.-", "Q"},
                { ".-.", "R"},
                {"...", "S" },
                { "-", "T"},
                { "..-", "U"},
                {"...-", "V" },
                { ".--", "X"},
                { "-..-", "W"},
                {"-.--", "Y" },
                { "--..", "Z"},
                { "/", " "}
            };}
        }
        public static List<string> Frases
        {
            get { return new List<string>()
            {
                    "Socorro.",
                    "Help.",
                    "Estou correndo perigo.",
                    "Fica.",
                    "Não vai.",
                    "Tempestade a frente.",
                    "Estou na estante."
            };}
            set {}
        }
        public static List<string> FrasesCodigoMorse 
        {
            get { return new List<string>()
            {
               "... --- -.-. --- .-. .-. ---",
               ".... . .-.. .--.",
               ". ... - --- ..- / -.-. --- .-. .-. . -. -.. --- / .--. . .-. .. --. ---",
               "..-. .. -.-. .-",
               "-. --- / ...- .- ..",
               "- . -- .--. . ... - .- -.. . / .- / ..-. .-. . -. - .",
               ". ... - --- ..- / -. .- / . ... - .- -. - ."
            };}
        }

    }
}
