using System.Globalization;

namespace ExerciciosPT1
{
    public class SalarioBonus
    {
        public static void Conteudo()
        {
            string nome;
            double salario, vendas, total;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            total = salario + (vendas * 0.15);

            Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
