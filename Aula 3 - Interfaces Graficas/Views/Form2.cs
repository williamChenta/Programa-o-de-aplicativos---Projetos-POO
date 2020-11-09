using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Aula_3___Interfaces_Graficas.Views
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            btnVoltar.Click += voltar;
        }

        private void voltar(object sender, EventArgs e)
        {
            new Form1().Show();
            Visible = false;
        }
    }
}
