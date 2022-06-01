using System;
using System.Collections.Generic;
using UnderConstruction;
using UnderConstruction.Mock;
using System.Linq;

namespace TestBuild
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Program.Initial();


            MorseCode Result = new(MorseCodeTest.Morp);


            var traduzidas = string.Join(" ", MorseCodeTest.FrasesCodigoMorse.Select(x => Result.Decode(x))).ToString();
            traduzidas.Split(".");

            //var t = string.MorseCodeTest.FrasesCodigoMorse.Select(x => Result.Decode(x)).ToString();




            //Verificando endereços ivp4 válidos

            List<string> enderecosipv4 = new()
            {
                "1.2.3",
                "1.2.3.4.5",
                "123.456.78.90",
                "123.045.067.089",
                "123.45.67.89",
                "01.02.03.04",
                "255.255.255.255",
                "123.194.123.255",
                "195.299.299.298",
                "333.333.333.333"
            };
            ValidationIpv4.ValidationIpv4Regex(enderecosipv4);

        }
        public static void Initial()
        {
            Console.WriteLine("- Projetos existentes : \n\n01 - Traduzir código Morse\n02 - Validação de Ipv4\n\nSelecione o número de acordo com o desejado.");
            
            var response = Convert.ToInt32(Console.ReadLine());

            switch (response)
            {
                case 1:
                    MorseCode Result = new(MorseCodeTest.Morp);
                    Console.WriteLine("\nDecodificando códigos: ");

                    Console.WriteLine("\nCodificando códigos: ");
                    break;
                case 2:
                    Console.WriteLine("Deu certo o segundo");
                    break;
                default:
                    Console.WriteLine("Deu certo o Terceiro");
                    break;
            }
            
        }
    }
}
