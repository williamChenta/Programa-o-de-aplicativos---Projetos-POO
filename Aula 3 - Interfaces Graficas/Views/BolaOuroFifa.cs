using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Aula_3___Interfaces_Graficas.Models;


namespace Aula_3___Interfaces_Graficas.Views
{
    public partial class BolaOuroFifa : Form
    {
        public BolaOuroFifa()
        {
            InitializeComponent();
            carregaJogadores();
            button1.Click += votar;
        }

        private void votar(object sender, EventArgs e)
        {
            Jogador selecionado = (Jogador) comboBox1.SelectedItem;
            selecionado.qtdeVotos++;
        }

        private void carregaJogadores()
        {
            comboBox1.DataSource = Program.jogadores;
        }
    }
}
