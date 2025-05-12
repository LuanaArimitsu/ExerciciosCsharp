using System.Globalization;

namespace ExerciciosPT1
{
    public class Imc
    {
        public static void Conteudo()
        {
            double peso, altura, imc;

            peso = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Abaixo do peso");
            }
            else if (imc <= 24.9)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc <= 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else if (imc <= 34.9)
            {
                Console.WriteLine("Obesidade grau 1");
            }
            else if (imc <= 39.9)
            {
                Console.WriteLine("Obesidade grau 2");
            }
            else
            {
                Console.WriteLine("Obesidade grau 3 (Mórbida)");
            }
        }
    }
}
