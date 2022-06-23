using System;
using System.Collections.Generic;
using System.Linq;
using UnderConstruction.Interfaces;

namespace UnderConstruction
{
    public class AboutNumbers : IConector
    {
        public string Text { get => "03 - Codewars envolvendo números e matemática\n\n"; set => throw new NotImplementedException(); }
        public string UrlKata { get => "https://www.codewars.com/kata/514b92a657cdc65150000006/train/csharp"; set => throw new NotImplementedException(); }

        public static int Multiplesofn(int number)
        {
            List<int> numbers = new List<int>();
            int count = number;
            //select all numbers after the numbers pased 
            while (count > 0 ) {numbers.Add(count--);}
            numbers.Remove(numbers.Where(x => x == number).FirstOrDefault());
            //select the multiples of 3 or 5 about that list
            var multiples = numbers.Where(num => num % 3 == 0 || num % 5 == 0).ToList();
            //sun all numbers and show the result.
            return multiples.Sum(x => x);
     
        }
    }
}

