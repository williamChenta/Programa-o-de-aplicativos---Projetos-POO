using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula_4___Herança.Models;
using Aula_4___Herança.ModelsBanco;

namespace Aula_4___Herança
{
    class Program : Conta
    {
        static void Main(string[] args)
        {
            Conta william = new Conta()
            {
                numero = 3245,
                saldo = 1000,
                titular = "William Chenta"
            };

            william.sacar(700);
            william.emprestimo(400);

            ContaCorrente joao = new ContaCorrente()
            {
                numero = 3336,
                saldo = 10000,
                titular = "João da Silva"
            };

            joao.emprestimo(400);
            joao.sacar(700);

            ContaPrime oscar = new ContaPrime()
            {
                titular = "Oscar de oliveira",
                limite = 5000,
                numero = 5477,
                saldo = 10000,
                PrcJurosEmprestimo = 0
            };

            oscar.emprestimo(2000);
        }
    }
}
