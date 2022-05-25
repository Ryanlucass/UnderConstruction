using System.Collections.Generic;
using System.Linq;

namespace UnderConstruction
{
   public class MaratonaFilmes {

        public static int acharMinimoDeDias(List<float> duracoes)
        {
            List<float> ListaCorreta = new();
 
            duracoes.Sort();

            int count = 0;
;

            var primeiro = duracoes.LastOrDefault();

            //count++;
            ListaCorreta.Add(primeiro);

            // var posicao = duracoes.Last();
            //foreach (var i in duracoes)
            //{
            //    t = tempo - i;
            //    if(i <= t)
            //    {
            //        ListaCorreta.Add(i);
            //        count++;
            //        if()
            //    }
            //    else
            //    {
            //        ListaCorreta.Add(i);
            //        count++;
            //    }

            //}

            var tempo = 0;

            for (int i = 0; i <= duracoes.Count; i++)
            {
                if (count <= 0)
                {
                    tempo = 3 - i;
                    count++;
                }

                tempo = 3 - i;
                
                if(duracoes.Any(x => tempo <= i))
                {
                    count++;
                }
                else
                {
                    count++;
                }

            }


            return 0;
        }

    }

}

