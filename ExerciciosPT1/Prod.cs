using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPT1
{
    public class Prod
    {
        public static void Conteudo()
        {
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int PROD = A * B;

            Console.WriteLine("PROD = " + PROD);
        }
    }
}
