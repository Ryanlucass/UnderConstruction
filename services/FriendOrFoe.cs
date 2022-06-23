using System.Collections.Generic;
using System.Linq;
using UnderConstruction.Interfaces;

namespace UnderConstruction
{
    public class FriendOrFoe: IConector
    {
        public string Text {
            get { return "Verica amiga ou inimigo;"; }
            set { } 
        }
        public string UrlKata
        {
            get { return "https://www.codewars.com/kata/55b42574ff091733d900002f/train/csharp"; }
            set { }
        }


        public IEnumerable<string> CheckFriend (string[] names) => names.Where(x => x.Length == 4);
    }
}

