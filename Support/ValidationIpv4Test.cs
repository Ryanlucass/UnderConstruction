using System.Collections.Generic;

namespace UnderConstruction.Mock
{
    public static class ValidationIpv4Test
    {
        public static List<string> EnderecoIpv4
        {
            get 
            { return new List<string>() {
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
            }
        }
    }
}
