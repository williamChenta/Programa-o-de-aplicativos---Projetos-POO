using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_3___Interfaces_Graficas.Models
{
    class Time
    {
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
                    throw new Exception("Nome inválido");
                }
            }
        }

        public Time()
        {

        }

        public int titulosMundiais { get; set; }

        public Time(string _nome, int _titulosMundiais)
        {
            Nome = _nome;
            titulosMundiais = _titulosMundiais; 
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
