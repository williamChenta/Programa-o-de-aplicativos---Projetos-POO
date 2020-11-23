using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_3___Interfaces_Graficas.Models
{
    class Jogador
    {
        public Time time { get; set; }

        private string nome;

        public string Nome
        {
            get { return nome; }
            set {
                if (value.Length >= 3)
                {
                    nome = value; 
                } else
                {
                    throw new Exception("Nome precisa ter pelo menos 3 caracteres!");
                }
            }
        }



        public string posicao { get; set; }
        public int qtdeVotos { get; set; }
    }
}
