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
            Funcionario william = new Funcionario("william");

            Funcionario joao = new Funcionario("joao da silva", 44);
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
