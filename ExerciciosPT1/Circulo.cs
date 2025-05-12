using System.Globalization;
namespace ExerciciosPT1
{
    public class Circulo
    {
        public static void Conteudo()
        {
            string entrada = Console.ReadLine();
            double raio = double.Parse(entrada, CultureInfo.InvariantCulture);
            double pi = 3.14159;
            double area = pi * raio * raio;

            Console.WriteLine("A=" + area.ToString("F4"));
        }
    }
}
