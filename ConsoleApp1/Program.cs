using System;

namespace Emprestimo
{
    class Program
    {
        static void Main(string[] args)
        {
            double dvalorEmprestimo = 0;
            int iqtdParcela = 0;
            double dtaxaJuros = 1;

            Console.WriteLine("Bem vindo ao sistema de emprestimo.");

            Console.WriteLine("Qual o valor do emprestimo: ");
            dvalorEmprestimo = double.Parse(Console.ReadLine());

            Console.WriteLine("O Valor do emprestimo solicitado é: R$ " + dvalorEmprestimo);

            Console.WriteLine("Qual a quantidade de parcelas? ");
            iqtdParcela = int.Parse(Console.ReadLine());

            Console.WriteLine("Taxa de juros? ");
            dtaxaJuros = double.Parse(Console.ReadLine());

            int qtdDiasInicio = 0;
            double valorParcela = dvalorEmprestimo / iqtdParcela;
            int Parcela = 0;
            double JurosLinear = 0;
            double JurosExponencial = 0;
            double PrincipalParcela = 0;
            double TotalParcela = 0;
            double TotalParcelaExponencial = 0;

            for (int i = 1; i <= iqtdParcela; i++)
            {
                qtdDiasInicio = qtdDiasInicio + 30;
                Parcela = i;
                JurosLinear = valorParcela * dtaxaJuros * qtdDiasInicio / (100 * 30);
                JurosExponencial = JurosLinear * Math.Pow((1 + (dtaxaJuros / 100)), ((qtdDiasInicio / 30) - 1));
                PrincipalParcela = valorParcela;
                TotalParcela = valorParcela + JurosLinear;
                TotalParcelaExponencial = valorParcela + JurosExponencial;

                Console.WriteLine("Parcela : " + Parcela + " Principal Parcela: " + PrincipalParcela + " Juros Linear: " + JurosLinear + " Total ParcelaLinear: " 
                    + TotalParcela + " Juros Exponencial: " + JurosExponencial.ToString("F2") + " Total Parcela Exponencial: " + TotalParcelaExponencial.ToString("F2"));
            }

            Console.ReadLine();

        }
    }
}
