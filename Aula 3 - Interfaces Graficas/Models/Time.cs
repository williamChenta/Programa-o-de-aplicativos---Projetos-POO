using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_3___Interfaces_Graficas.Models
{
    class Time
    {
        public string nome { get; set; }
        public int titulosMundiais { get; set; }

        public Time(string _nome, int _titulosMundiais)
        {
            nome = _nome;
            titulosMundiais = _titulosMundiais; 
        }

        public override string ToString()
        {
            return nome;
        }
    }
}
