using Aula_3___Interfaces_Graficas.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aula_3___Interfaces_Graficas.Views
{
    public partial class CadastroJogadores : Form
    {
        Time[] times = new Time[10];

        public CadastroJogadores()
        {
            InitializeComponent();
            carregaTimes();
            button1.Click += salvar;
            button2.Click += resultados;
        }

        private void resultados(object sender, EventArgs e)
        {
            new ResultadoBolaOuro().Show();
            Visible = false;
        }

        private void carregaTimes()
        {
            times[0] = new Time("Corinthians", 2);
            times[1] = new Time("Flamengo", 0);
            times[2] = new Time("Barcelona", 5);

            comboBox1.DataSource = times;
        }

        private void salvar(object sender, EventArgs e)
        {
            try
            {
                Jogador j = new Jogador()
                {
                    Nome = textBox1.Text,
                    posicao = textBox2.Text,
                    time = (Time)comboBox1.SelectedItem,
                    qtdeVotos = 0
                };

                Program.jogadores.Add(j);
                MessageBox.Show("Salvo com sucesso!");
                carregaJogadores();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro ao tentar salvar. {ex.Message}");
            }

        }

        private void carregaJogadores()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Program.jogadores;
        }
    }
}
