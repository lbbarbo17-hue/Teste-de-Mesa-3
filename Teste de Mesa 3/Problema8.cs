using System;

namespace ProjetoRendimento
{
    class Program
    {
        static void Main(string[] args)
        {
            Investimento meuInvestimento = new Investimento();

            Console.WriteLine("Digite o Valor Presente Investido (R$):");
            meuInvestimento.ValorPresente = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a Taxa de Juros mensal em % (Ex: para 2% digite 2):");
            meuInvestimento.TaxaJuros = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.WriteLine("Digite o Número de Períodos (meses):");
            meuInvestimento.PeriodoMeses = Convert.ToInt32(Console.ReadLine());

            meuInvestimento.ExibirTabelaRendimento();

            Console.WriteLine("\nPressione ENTER para fechar...");
            Console.ReadLine();
        }
    }
}


using System;

namespace ProjetoRendimento
{
    public class Investimento
    {
        public double ValorPresente { get; set; }
        public double TaxaJuros { get; set; }
        public int PeriodoMeses { get; set; }

        public void ExibirTabelaRendimento()
        {
            double saldoAtual = ValorPresente;

            Console.WriteLine("\n---------------------------------------------------------");
            Console.WriteLine("Mês | Saldo Inicial   | Rendimento     | Saldo Final");
            Console.WriteLine("---------------------------------------------------------");

            for (int mes = 1; mes <= PeriodoMeses; mes++)
            {
                double saldoInicialDoMes = saldoAtual;

                double rendimentoDoMes = saldoInicialDoMes * TaxaJuros;

                saldoAtual = saldoInicialDoMes + rendimentoDoMes;

                Console.WriteLine($"{mes,-3} | {saldoInicialDoMes,-15:C} | {rendimentoDoMes,-14:C} | {saldoAtual:C}");
            }
            Console.WriteLine("---------------------------------------------------------");
        }
    }
}
