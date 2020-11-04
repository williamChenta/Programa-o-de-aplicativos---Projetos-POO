using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2___Encapsulamento
{
    public class Funcionario
    {
        private string nome;
        public string Nome { 
            get
            {
                return nome;
            } set
            {
                if (value.Length >= 3)
                {
                    nome = value;
                } else
                {
                    throw new Exception("O valor informado é inválido. Nome precisa ter pelo menos 3 caracteres");
                }
            }
        }

        public string email;
        private int idade;
        public int Idade { 
            get {
                return idade;
            } set {
                if (value > 0 && value <= 110)
                {
                    idade = value;
                } else
                {
                    throw new Exception("O valor informado é inválido. Informe um valor entre 1 e 110");
                }            
            } 
        }



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
