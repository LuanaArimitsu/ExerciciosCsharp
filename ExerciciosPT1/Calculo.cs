using System;
using System.Globalization;

class Program
{
    public class Calculo
    {
        public static void Conteudo()
        {
            string[] linha1 = Console.ReadLine().Split(' ');
            int cod1 = int.Parse(linha1[0]);
            int qtd1 = int.Parse(linha1[1]);
            double valor1 = double.Parse(linha1[2], CultureInfo.InvariantCulture);

            string[] linha2 = Console.ReadLine().Split(' ');
            int cod2 = int.Parse(linha2[0]);
            int qtd2 = int.Parse(linha2[1]);
            double valor2 = double.Parse(linha2[2], CultureInfo.InvariantCulture);

            double total = (qtd1 * valor1) + (qtd2 * valor2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
    
}
