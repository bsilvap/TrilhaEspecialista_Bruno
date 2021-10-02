using AvaliacaoFinal.Entities;
using System;

namespace AvaliacaoFinal
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("OLÁ FUNCIONÁRIO!)");
            Console.Write("POR GENTILEZA, INFORME O TIPO CONTRATUAL, SELECIONANDO 1 CASO VOCÊ SEJA FUNCIONÁRIO INTERNO, E 2 CASO VOCÊ SEJA FUNCIONÁRIO TERCEIRO(EXTERNO): ");

            int tipoDeContrato = int.Parse(Console.ReadLine());

            if (tipoDeContrato == 1)
            {
                Funcionario funcionario01 = new Funcionario("Roberto Gómez Bolaños", 8, 40.0);

                Console.WriteLine("OLÁ!");
                Console.WriteLine();
                Console.WriteLine("SEGUEM ABAIXO AS SUAS INFORMAÇÕES:");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                funcionario01.CalculaSalario(0);
                funcionario01.ImprimeDados();
                Console.ResetColor();

            }
            else if (tipoDeContrato == 2)
            {
                Funcionario funcionario02 = new FuncionarioTerc("Ramón Valdés", 8, 40.0, "Astrolupi LTDA", 0.12);

                Console.WriteLine("OLÁ!");
                Console.WriteLine();
                Console.WriteLine("SEGUEM ABAIXO AS SUAS INFORMAÇÕES:");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Cyan;
                funcionario02.CalculaSalario(0);
                funcionario02.ImprimeDados();
                Console.ResetColor();

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("TIPO CONTRATUAL INCORRETO. POR FAVOR, LOGUE NOVAMENTE E CONSIDERE APENAS AS OPÇÕES 1 PARA FUNCIONÁRIO INTERNO, E 2 PARA FUNCIONÁRIO TERCEIRO(EXTERNO).");
                Console.ResetColor();
            }

        }
    }
}
