using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4___Herança.ModelsBanco
{
    class ContaPrime : Conta
    {
        public decimal limite { get; set; }

        public override void emprestimo(decimal valor)
        {
            if (valor <= saldo + limite)
            {
                base.emprestimo(valor);
            } else
            {
                Console.WriteLine("Valor excede o seu limite de credito. Negado");
            }
        }
    }
}
