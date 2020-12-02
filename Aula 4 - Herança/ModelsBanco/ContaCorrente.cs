using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4___Herança.ModelsBanco
{
    class ContaCorrente : Conta
    {
        public double taxaSaque { get; set; }

        public ContaCorrente()
        {
            PrcJurosEmprestimo = 0.05;
            taxaSaque = 0.07;
        }

        public override void emprestimo(decimal valor)
        {
            base.emprestimo(valor);
        }

        public override void sacar(decimal valor)
        {
            double taxa = double.Parse(valor.ToString()) * taxaSaque;

            if (valor <= saldo)
            {
                saldo -= valor + decimal.Parse(taxa.ToString());
                Console.WriteLine($"Conta: Valor sacado com sucesso. A taxa é: {taxa}.\nSaldo atual: {saldo}");
            }
            else
            {
                Console.WriteLine("Conta: Saldo insuficiente");
            }
        }
    }
}
