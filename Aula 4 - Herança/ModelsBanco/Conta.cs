using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4___Herança.ModelsBanco
{
    class Conta
    {
        public int numero { get; set; }
        public string titular { get; set; }
        public decimal saldo { get; set; }
        public double PrcJurosEmprestimo { get; set; }

        public Conta()
        {
            PrcJurosEmprestimo = 0.11;
        }

        public virtual void sacar(decimal valor)
        {
            if (valor <= saldo)
            {
                saldo -= valor;
                Console.WriteLine($"Conta: Valor sacado com sucesso.\nSaldo atual: {saldo}");
            } else
            {
                Console.WriteLine("Conta: Saldo insuficiente");
            }
        }

        public virtual void emprestimo(decimal valor)
        {
            decimal valorComJuros = valor + (valor * decimal.Parse(PrcJurosEmprestimo.ToString()));
            Console.WriteLine($"olá {titular}. Seu emprestimo sera cobrado em 10x de {valorComJuros / 10}");
        }
    }
}
