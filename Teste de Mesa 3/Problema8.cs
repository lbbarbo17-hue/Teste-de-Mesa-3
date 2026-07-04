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
