using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinus
{
    public static class Result
    {
        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */

        public static void plusMinus(List<int> arr)
        
        {
            float portion = 1f / arr.Count();

            float pozitive = 0f;
            float negative = 0f;
            float zero = 0f;


            arr.ForEach(x =>
            {
                if (x > 0) pozitive = pozitive + portion;
                if (x < 0) negative = negative + portion;
                if (x == 0) zero = zero + portion;
            });

            

            Console.WriteLine($"{pozitive}");
            Console.WriteLine(pozitive.ToString());

            Console.WriteLine($"{negative}");
            Console.WriteLine($"{zero}", zero);
        }
    }

}
