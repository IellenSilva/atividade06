using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atividadeaula6
{
    class Program
    {
        static void Main(string[] args)
        {
            string periodo;
            int dia;
           int mes;

            Console.WriteLine("Bem-vindo ao Conradito passagens aéreas");
            Console.WriteLine("escolha um mes para sua viagem");
            Console.WriteLine($"AGOSTO 08 \n SETEMBRO 09  \n OUTUBRO 10 \n ");
           mes = int.Parse(Console.ReadLine());


            if (mes > 7 && mes < 11)
            {
                Console.WriteLine("Mes Valido!");

            }
           else
            {
                Console.WriteLine("Mes invalido");

            }

            Console.WriteLine("Escolha  um dia para sua Viagem entre os dia 6 eo dia 21\n");
           dia = int.Parse(Console.ReadLine());

            if(dia > 6 && dia <21)
            {
                Console.WriteLine("Data Marcada!");

            }
            else
            {
                Console.WriteLine("Dia invalido!");

            }

            Console.WriteLine("Escolha o periodo para sua viagem :\n manhã \n tarde \n noite");
           periodo = Console.ReadLine();
            Console.WriteLine("Sua Passagem foi Comprada com Sucesso!\n\n");
            Console.WriteLine($"Viagem marcada para o dia {dia} mes de {mes} periodo da {periodo} !");

            Console.ReadKey();
        }
    }
}
