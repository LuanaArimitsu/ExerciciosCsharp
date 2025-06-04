using System;
using System.Globalization;

namespace ExerciciosPT1
{ 
    public class Conversao
    {
        public static void Conteudo()
        {
            int N, horas, resto, minutos, segundos;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            resto = N % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine($"{horas}:{minutos}:{segundos}");
        }
    }

}