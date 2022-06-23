using System;
using UnderConstruction.Interfaces;

namespace UnderConstruction
{
    public class BoucingBalls : IConector
    {
        public string Text { get => "\n\n03 - Verifica quantas vezes é vista a bola"; set => throw new NotImplementedException();}
        public string UrlKata { get => "https://www.codewars.com/kata/5544c7a5cb454edb3c000047/train/csharp"; set => throw new NotImplementedException(); }

        public int bouncingBall(double h, double bounce, double window)
        {
            if (h < 0 && bounce < 0 && bounce > 1 && window > h) { return -1;}

            int count = 1;
            h = h * bounce;

            while (h > window)
            {
                count+=2;
                
                h = h * bounce;
            }
            return count;
        }

    }
}

