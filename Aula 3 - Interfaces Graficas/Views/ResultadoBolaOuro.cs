using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aula_3___Interfaces_Graficas.Views
{
    public partial class ResultadoBolaOuro : Form
    {
        public ResultadoBolaOuro()
        {
            InitializeComponent();
            carregaResultado();
        }

        private void carregaResultado()
        {
            int linha = 0;
            Program.jogadores.ForEach(jogador =>
            {
                Label nomeJogador = new Label();
                nomeJogador.Text = jogador.Nome;
                tableLayoutPanel1.Controls.Add(nomeJogador, 0, linha);

                Label qtdeVotos = new Label();
                qtdeVotos.Text = jogador.qtdeVotos.ToString();
                tableLayoutPanel1.Controls.Add(qtdeVotos, 1, linha);

                linha++;
            });
        }
    }
}
