using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciciosPT1
{
    public class Gasto
    {
        public static void Conteudo()
        {
            int tempo = int.Parse(Console.ReadLine());
            int velocidade = int.Parse(Console.ReadLine());

            int distancia = tempo * velocidade;
            double litros = distancia / 12.0;

            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
