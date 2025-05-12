using System;
using static Program;

namespace ExerciciosPT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um exercicio");
            var escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    Circulo.Conteudo();
                    break;
                case "2":
                    Soma.Conteudo();
                    break;
                case "3":
                   Prod.Conteudo();
                   break;
                case "4":
                  Media1.Conteudo();
                  break;
                case "5":
                    Media2.Conteudo();
                    break;
                case "6":
                    Diferenca.Conteudo();
                    break;
                case "7":
                    Salario.Conteudo();
                    break;
                case "8":
                    Calculo.Conteudo();
                    break;
                case "9":
                    Consumo.Conteudo();
                    break;
                case "10":
                    Distancia.Conteudo();
                    break;
                case "11":
                    Gasto.Conteudo();
                    break;
                case "12":
                    Retangulo.Conteudo();
                    break;
                case "13":
                    Imc.Conteudo();
                    break;
                case "14":
                    Idade.Conteudo();
                    break;
                case "15":
                    SalarioBonus.Conteudo();
                    break;
                default:
                    Console.WriteLine("Exercicio não encontrado.");
                    break;
            }
        }
    }
}