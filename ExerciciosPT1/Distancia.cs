using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosPT1
{
    public class Distancia
    {
        public static void Conteudo()
        {
            int distancia = int.Parse(Console.ReadLine());
            int tempo = distancia * 2;

            Console.WriteLine(tempo + " minutos");
        }
    }
}
