using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aula_3___Interfaces_Graficas.Models;

namespace Aula_3___Interfaces_Graficas.Views
{
    public partial class Form1 : Form
    {
        List<Time> times = new List<Time>()
        {
            new Time("Corinthians", 2),
            new Time("Flamengo", 0),
            new Time("Palmeiras", 0)
        };

        public Form1()
        {
            InitializeComponent();
            btnSalvar.Click += salvar;
            cmbTimes.DataSource = times;
            tblTimes.DataSource = times;
            btnCadastro.Click += abrirTelaCadastro;
        }

        private void abrirTelaCadastro(object sender, EventArgs e)
        {
            new Form2().Show();
            Visible = false;
        }

        private void salvar(object sender, EventArgs e)
        {
            string nome = txtNome.Text;

            Time time = new Time();

            try
            {
                time.Nome = txtNome.Text;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
