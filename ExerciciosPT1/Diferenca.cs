using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPT1
{
    public class Diferenca
    {
        public static void Conteudo()
        {
            int A = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int B = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int C = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            int D = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int DIFERENCA = (A * B - C * D);

            Console.WriteLine("DIFERENCA = " + DIFERENCA);
        }
    }
}
