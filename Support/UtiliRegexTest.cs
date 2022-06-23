using System.Collections.Generic;

namespace UnderConstruction.Mock
{
    public static class UtiliRegexTest
    {
        public static List<string> EnderecoIpv4
        {
            get
            {
                return new List<string>() {
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

        public static List<string> FrasesPangram
        {
            get
            {
                return new List<string>()
                {
                    "abcdefghijklmnopqrstuvxyz",
                    "aaawerwjkhdsfs",
                    "aslçdkfji",
                    "The quick brown fox jumps over the lazy dog",
                    "ssljkfhudf"
                };
            }
        }
    }
    public static class BoucingBallsTest
    {
        public static BucingBallsObj BucingObj { get; set; }

        public static List<BucingBallsObj> ListBucing {
            get
            {
                return new List<BucingBallsObj>()
                {
                    new BucingBallsObj{Height = 3.0, Balance = 0.66, Window = 1.5},
                    new BucingBallsObj{Height = 30.0, Balance = 0.66, Window = 1.5},
                    new BucingBallsObj{Height = 30.0, Balance = 0.23, Window = 1.5},
                    new BucingBallsObj{Height = 13.0, Balance = 0, Window = 1.5},
                    new BucingBallsObj{Height = 43.0, Balance = 2, Window = 1.5},
                    new BucingBallsObj{Height = 23.0, Balance = 3, Window = 1.5},
                    new BucingBallsObj{Height = 34.0, Balance = 0, Window = 45},
                    new BucingBallsObj{Height = 0, Balance = 2, Window = 50},
                    new BucingBallsObj{Height = 33, Balance = 3, Window = 1.5}
                };
            }
        }

        public class BucingBallsObj
        {
            public double Height { get; set; }
            public double Balance { get; set; }
            public double Window { get; set; }
        }
    }
}
