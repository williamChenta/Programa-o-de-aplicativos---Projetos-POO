using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aula_2___Encapsulamento.Models;

namespace Aula_2___Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario william = new Funcionario();


            Console.WriteLine("informe seu nome: ");
            var nome = Console.ReadLine();


            Funcionario joao = new Funcionario(nome, 44);
            joao.Idade = 55;

            Funcionario maria = new Funcionario();
            


            try
            {
                william.Idade = 12;
                william.cargo = "Professor";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(william.Nome);
        }
    }
}
