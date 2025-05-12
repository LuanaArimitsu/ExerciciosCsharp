using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciciosPT1
{
    public class Consumo
    {
        public static void Conteudo()
        {
            int distancia = int.Parse(Console.ReadLine());
            double combustivel = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumo = distancia / combustivel;

            Console.WriteLine(consumo.ToString ("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}
