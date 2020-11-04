using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2___Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario william = new Funcionario();

            try
            {
                william.Idade = 12;
                william.Nome = "william";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(william.Nome);
        }
    }
}
