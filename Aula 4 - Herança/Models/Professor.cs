using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4___Herança.Models
{
    public class Professor : Pessoa
    {
        public override string Nome { 
            get => base.Nome; 
            set {
                if (value.Length >= 4)
                {
                    base.Nome = value;
                } else
                {
                    throw new Exception("Nome de professor inválido!");
                }
            }
        }

        public override void imprimirCurriculo()
        {
            Console.WriteLine($"Nome: {Nome}. Este profissional é um professor");
        }
    }
}
