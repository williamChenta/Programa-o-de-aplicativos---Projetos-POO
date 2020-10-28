using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1___Objetos_e_Classes
{
    public class Funcionario
    {
        public string nome;
        public string email;
        public int idade;
        public string telefone;
        public double salario;
        public string cargo;

        public void imprimirFicha()
        {
            Console.WriteLine($"Nome: {nome}\nEmail: {email}\nIdade: {idade}");
        }
        public void calcularAumento()
        {
            if (idade > 30)
            {
                salario = salario * 1.15;
                Console.WriteLine($"seu novo salario é: R${salario}");
            } else
            {
                Console.WriteLine("Você não atingiu a idade necessária ainda!");
            }
        }

        public override string ToString()
        {
            return $"Nome: {nome}\nEmail: {email}\nIdade: {idade}";
        }
    }
}
