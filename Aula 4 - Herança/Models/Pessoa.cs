using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4___Herança.Models
{
    public class Pessoa
    {
        public int matricula { get; set; }
        private string nome;

        public virtual string Nome
        {
            get { return nome; }
            set {
                if (value.Length >= 3)
                {
                    nome = value; 
                } else
                {
                    throw new Exception("Nome de pessoa inválido!");
                }
            }
        }

        public string endereco { get; set; }
        public string email { get; set; }

        public Pessoa()
        {

        }

        public Pessoa(int _matricula, string _nome, string _endereco, string _email)
        {
            matricula = _matricula;
            nome = _nome;
            endereco = _endereco;
            email = _email;
        }

        public virtual void imprimirCurriculo()
        {
            Console.WriteLine($"Nome: {nome}\nEndereço: {endereco}\n Email: {email}");
        }
    }
}
