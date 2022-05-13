using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnderConstruction;
using System.Collections.Generic;

namespace TesteTemporario
{
    [TestClass]
    public class UnitTest1
    {
        private static readonly Dictionary<string, string> _dictionary = new()
        {
            { ".-", "A" },
            { "-...", "B" },
            { "-.-.", "C" },
            { "-..", "D" },
            { ".", "E" },
            { "..-.", "F" },
            { "--.", "G" },
            { "....", "H" },
            { "..", "I" },
            { ".---", "J" },
            { "-.-", "K" },
            { ".-..", "L" },
            { "--", "M" },
            { "-.", "N" },
            { "---", "O" },
            { ".--.", "P" },
            { "--.-", "Q" },
            { ".-.", "R" },
            { "...", "S" },
            { "-", "T" },
            { "..-", "U" },
            { "...-", "V" },
            { ".--", "X" },
            { "-..-", "W" },
            { "-.--", "Y" },
            { "--..", "Z" },
            { "/", " " }
        };

        [TestMethod]
        public static void Incriptando()
        {
            var t1 = new MorseCode(_dictionary);

            t1.Decode("sdsdsd");

        }

        [TestMethod]
        public static void Descriptando()
        {

        }
    }
}
