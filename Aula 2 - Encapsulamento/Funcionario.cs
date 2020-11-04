using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2___Encapsulamento
{
    public class Funcionario
    {
        public Funcionario() { }

        public Funcionario(string _nome)
        {
            Nome = _nome;
        }

        public Funcionario(string _nome, int _idade)
        {
            Nome = _nome;
            Idade = _idade;
        }

        public Funcionario(int idade, string _email)
        {
            email = _email;
        }

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

        private string telefone;

        public string Telefone
        {
            get { return telefone; }
            set {
                if (value.Length >= 10)
                {
                    telefone = value; 
                } else
                {
                    throw new Exception("Telefone informado é invalido");
                }
            }
        }




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
