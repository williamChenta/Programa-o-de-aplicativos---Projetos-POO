using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_1___Objetos_e_Classes
{
    class Program
    {        
        static void Main(string[] args)
        {
            //william e golle são objetos da classe Funcionario
            Funcionario william = new Funcionario();
            william.nome = "william chenta";
            william.idade = 44;
            william.salario = 1000;

            Console.WriteLine(william);


            Funcionario nasatto = new Funcionario()
            {
                cargo = "Coordenador",
                email = "nasatto@gmail.com",
                telefone = "4444-4444"
            };

            //nasatto.idade = 25;
            //nasatto.telefone = "5555-5555";


            ////Console.WriteLine($"o telefone do {william.nome} é: {william.telefone}");

            ////william.imprimirFicha();
            //william.calcularAumento();

            ////Funcionario golle = new Funcionario();
            ////golle.nome = "jorge golle";
            ////golle.idade = 40;
            ////golle.telefone = "444-4444";

            ////Console.WriteLine($"Deseja imprimir a idade do {william.nome} ?");
            //if (bool.Parse(Console.ReadLine()))
            //{
            //    Console.WriteLine($"a idade do {william.nome} é: {william.idade}");
            //}
        }
    }
}
