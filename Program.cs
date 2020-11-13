using System;

namespace AtividadeIndividual1
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variavel
            int idade = 0;
            int anos = (idade * 12);
            int dias = idade * 365;
            int meses = idade * 12;
            int horas = dias * 24;
            int minutos = horas * 60;
         
            
            //Entrada de dados

            Console.Write("Digite sua idade");
            idade = int.Parse(Console.ReadLine());

            //Processamento

            System.Console.WriteLine("Idade em meses : " + meses);
            System.Console.WriteLine("Idade em dias : " + dias);
            System.Console.WriteLine("Idade em horas : " + horas);
            System.Console.WriteLine("Idade em minutos : " + minutos);



        }
    }
}
