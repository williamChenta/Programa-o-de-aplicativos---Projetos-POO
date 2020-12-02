using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4___Herança.Models
{
    class Aluno : Pessoa
    {
        public override void imprimirCurriculo()
        {
            base.imprimirCurriculo();
            Console.WriteLine("Essa pessoa é um aluno");
        }
    }
}
