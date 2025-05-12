using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPT1
{
    public class Soma
    {
        public static void Conteudo() { 
            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            int SOMA = A + B;

            Console.WriteLine("SOMA = " + SOMA);
        }
    }
}
